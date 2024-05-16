using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая.Interface
{
    public class CashPaymentStrategy : IPaymentStrategy
    {
        private readonly MainPresenter mainPresenter;
        private readonly PaymentPresenter paymentPresenter;  // Изменил на PaymentPresenter
        public event EventHandler PaymentCompleted;

        public CashPaymentStrategy(MainPresenter mainPresenter, PaymentPresenter paymentPresenter)
        {
            this.mainPresenter = mainPresenter;
            this.paymentPresenter = paymentPresenter;
        }

        public void Pay(decimal totalAmount)
        {
            decimal userBudget = mainPresenter.GetUserBudgetLabel();

            if (userBudget >= totalAmount)
            {
                decimal newBudget = userBudget - totalAmount;
                mainPresenter.SetUserBudget(newBudget);
                mainPresenter.UpdateBudgetAfterPayment(totalAmount);
                mainPresenter.Customer.ClearShoppingBasket();
                mainPresenter.UpdateShoppingCartView();
                mainPresenter.UpdateTotalAmount();

                paymentPresenter.OnPaymentCompleted(); // Вызываем событие PaymentCompleted

                MessageBox.Show($"Оплачено наличными. Сумма: {totalAmount} руб.");
            }
            else
            {
                MessageBox.Show("Недостаточно средств для оплаты наличными.");
            }
        }
    }

    public class CardPaymentStrategy : IPaymentStrategy
    {
        private readonly MainPresenter mainPresenter;
        private readonly PaymentPresenter paymentPresenter;  // Изменил на PaymentPresenter
        public event EventHandler PaymentCompleted;

        public CardPaymentStrategy(MainPresenter mainPresenter, PaymentPresenter paymentPresenter)
        {
            this.mainPresenter = mainPresenter;
            this.paymentPresenter = paymentPresenter;
        }

        public void Pay(decimal totalAmount)
        {
            decimal userBudget = mainPresenter.GetUserBudgetLabel();

            if (userBudget >= totalAmount)
            {
                decimal newBudget = userBudget - totalAmount;
                mainPresenter.SetUserBudget(newBudget);
                mainPresenter.UpdateBudgetAfterPayment(totalAmount);
                mainPresenter.Customer.ClearShoppingBasket();
                mainPresenter.UpdateShoppingCartView();
                mainPresenter.UpdateTotalAmount();
                

                paymentPresenter.OnPaymentCompleted(); // Вызываем событие PaymentCompleted

                MessageBox.Show($"Оплачено картой. Сумма: {totalAmount} руб.");
            }
            else
            {
                MessageBox.Show("Недостаточно средств для оплаты картой.");
            }
        }
    }

    public class BonusPaymentStrategy : IPaymentStrategy
    {
        private readonly MainPresenter mainPresenter;
        private readonly PaymentPresenter paymentPresenter;
        private readonly Label bonusLabel;  // Поле для хранения ссылки на метку BonusLabel

        public BonusPaymentStrategy(MainPresenter mainPresenter, PaymentPresenter paymentPresenter, Label bonusLabel)
        {
            this.mainPresenter = mainPresenter;
            this.paymentPresenter = paymentPresenter;
            this.bonusLabel = bonusLabel;  // Присваиваем переданный лейбл в поле bonusLabel
        }

        public void Pay(decimal totalAmount)
        {
            decimal maxBonusAmount = totalAmount / 2;
            decimal userBudget = mainPresenter.GetUserBudgetLabel();
           // int bonusPoints = mainPresenter.Customer.GetBonusPoints(mainPresenter);  // Получаем количество бонусных очков
            int bonusPoints = mainPresenter.bonusPoints;  // Получаем количество бонусных очков

            if (bonusPoints > 0 && !mainPresenter.isPayByBonus)
            {
                
                decimal bonusPayment = Math.Min(bonusPoints, maxBonusAmount);
                //bonusPayment = 10;
                decimal remainingAmount = totalAmount - bonusPayment;

                bonusPoints -= (int)bonusPayment;
                mainPresenter.bonusPoints = bonusPoints;
                // Обновляем текст лейбла с бонусами после оплаты бонусами

                bonusLabel.Text = bonusPoints.ToString();
                mainPresenter.BonusLabel.Text = bonusPoints.ToString();

                if (remainingAmount > 0 )
                {
                    mainPresenter.TotalAmountValue = remainingAmount;
                    mainPresenter.TotalAmountLabel.Text = remainingAmount.ToString();
                    mainPresenter.TotalAmountLabelPay.Text = remainingAmount.ToString();
                    mainPresenter.isPayByBonus = true;
                    MessageBox.Show($"Оплата бонусами (до 50% от суммы корзины) успешно выполнена. Оставшаяся сумма для оплаты: {remainingAmount} руб.");
                }
                else
                {
                    mainPresenter.Customer.ClearShoppingBasket();
                    mainPresenter.UpdateShoppingCartView();
                    mainPresenter.UpdateTotalAmount();
                    paymentPresenter.OnPaymentCompleted();
                    MessageBox.Show("Оплата всей суммы бонусами исчерпана.");
                }
            }
            else
            {
                MessageBox.Show("Недостаточно бонусов для оплаты или превышен лимит (50% от суммы корзины).");
            }
        }
    }

    public class PartialPaymentStrategy : IPaymentStrategy
    {
        private readonly MainPresenter mainPresenter;
        private readonly PaymentPresenter paymentPresenter;
        private readonly decimal cashAmount;
        private readonly decimal cardAmount;

        public PartialPaymentStrategy(MainPresenter mainPresenter, PaymentPresenter paymentPresenter, decimal cashAmount, decimal cardAmount)
        {
            this.mainPresenter = mainPresenter;
            this.paymentPresenter = paymentPresenter;
            this.cashAmount = cashAmount;
            this.cardAmount = cardAmount;
        }

        public void Pay(decimal totalAmount)
        {
            decimal userBudget = mainPresenter.GetUserBudgetLabel();

            if (userBudget >= totalAmount)
            {
                decimal remainingAmount = totalAmount;

                // Проверяем наличие средств наличными
                if (cashAmount > 0 && userBudget >= cashAmount)
                {
                    mainPresenter.SetUserBudget(userBudget - cashAmount);
                    remainingAmount -= cashAmount;
                    mainPresenter.UpdateBudgetAfterPayment(totalAmount); // Обновляем бюджет
                    mainPresenter.Customer.ClearShoppingBasket();
                    mainPresenter.UpdateShoppingCartView();
                    mainPresenter.UpdateTotalAmount();
                }

                // Проверяем наличие средств на карте
                if (cardAmount > 0 && userBudget >= cardAmount)
                {
                    mainPresenter.SetUserBudget(userBudget - cardAmount);
                    remainingAmount -= cardAmount;
                    mainPresenter.UpdateBudgetAfterPayment(totalAmount); // Обновляем бюджет
                    mainPresenter.Customer.ClearShoppingBasket();
                    mainPresenter.UpdateShoppingCartView();
                    mainPresenter.UpdateTotalAmount();
                }

                if (remainingAmount == 0)
                {
                    mainPresenter.Customer.ClearShoppingBasket();
                    mainPresenter.UpdateShoppingCartView();
                    mainPresenter.UpdateTotalAmount();
                    paymentPresenter.OnPaymentCompleted();
                    MessageBox.Show("Оплата частично успешно выполнена.");
                }
                else
                {
                    MessageBox.Show("Недостаточно средств для оплаты указанными способами.");
                }
            }
            else
            {
                MessageBox.Show("Недостаточно средств для оплаты частично.");
            }
        }
    }
}
