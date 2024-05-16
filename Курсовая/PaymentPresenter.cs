using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая.Interface;

namespace Курсовая
{
    public class PaymentPresenter
    {

        public event EventHandler PaymentCompleted;
        private readonly Customer Сustomer;
        private readonly MainPresenter mainPresenter;
        private readonly MainForm mainForm;

        private IPaymentStrategy paymentStrategy;
        public PaymentPresenter(MainForm mainForm, Label bonusLabel)
        {
            this.mainForm = mainForm;
     
        }
        public PaymentPresenter(Customer customer, MainPresenter mainPresenter)
        {

            this.Сustomer = customer;
            this.mainPresenter = mainPresenter;
        }
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            paymentStrategy = strategy;
        }
        public void Pay()
        {
            decimal totalAmount = mainPresenter.TotalAmountValue;
            paymentStrategy.Pay(totalAmount);
        }

        public void OnPaymentCompleted()
        {
            PaymentCompleted?.Invoke(this, EventArgs.Empty);
        }



        //Оплата наликом
        //public void PayWithCash()
        //{
        //    decimal totalAmount = mainPresenter.CalculateTotalAmount();
        //    decimal userBudget = mainPresenter.GetUserBudgetLabel();

        //    if (userBudget >= totalAmount)
        //    {
        //        // Оплата наличными возможна
        //        // Вычитаем сумму покупки из бюджета пользователя
        //        decimal NowBudget = userBudget - totalAmount;
        //        mainPresenter.SetUserBudget(NowBudget);
        //        mainPresenter.UpdateBudgetAfterPayment(totalAmount); // Обновляем бюджет
        //        mainPresenter.Customer.ClearShoppingBasket();
        //        mainPresenter.UpdateShoppingCartView();
        //        mainPresenter.UpdateTotalAmount();
        //        // Добавьте здесь код для обработки оплаты наличными

        //        OnPaymentCompleted(); // Вызываем событие PaymentCompleted

        //        MessageBox.Show($"Оплачено наличными. Сумма: {totalAmount} руб.");
                
        //    }
        //    else
        //    {
        //        MessageBox.Show("Недостаточно средств для оплаты наличными.");
        //    }
        //}

        ////Оплата картой
        //public void PayWithCard()
        //{
        //    decimal totalAmount = mainPresenter.CalculateTotalAmount();
        //    decimal userBudget = mainPresenter.GetUserBudgetLabel();

        //    if (userBudget >= totalAmount)
        //    {
        //        // Оплата картой возможна
        //        // Вычитаем сумму покупки из бюджета пользователя
        //        decimal NowBudget = userBudget - totalAmount;
        //        mainPresenter.SetUserBudget(NowBudget);
        //        mainPresenter.UpdateBudgetAfterPayment(totalAmount); // Обновляем бюджет

        //        mainPresenter.Customer.ClearShoppingBasket();
        //        mainPresenter.UpdateShoppingCartView();
        //        mainPresenter.UpdateTotalAmount();
        //        // Обновляем корзину и итоговую сумму


        //        OnPaymentCompleted(); // Вызываем событие PaymentCompleted

        //        MessageBox.Show($"Оплачено картой. Сумма: {totalAmount} руб.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Недостаточно средств для оплаты картой.");
        //    }
        //}
        ////Оплата бонусами
        //public void PayWithBonuses()
        //{   
        //    mainPresenter.Customer.ClearShoppingBasket();
        //    mainPresenter.UpdateShoppingCartView();
        //    mainPresenter.UpdateTotalAmount();

        //    OnPaymentCompleted();
        //    // Добавьте здесь код для обработки оплаты бонусами
        //    MessageBox.Show("Оплата бонусами. Спасибо за покупку!");
        //}

        //public void PayPartially(decimal cashAmount, decimal cardAmount)
        //{
        //    decimal totalAmount = mainPresenter.CalculateTotalAmount();
        //    decimal userBudget = mainPresenter.GetUserBudgetLabel();

        //    if (userBudget >= totalAmount)
        //    {
        //        decimal remainingAmount = totalAmount;

        //        // Проверяем наличие средств наличными
        //        if (cashAmount > 0 && userBudget >= cashAmount)
        //        {
        //            mainPresenter.SetUserBudget(userBudget - cashAmount);
        //            remainingAmount -= cashAmount;
        //            mainPresenter.UpdateBudgetAfterPayment(totalAmount); // Обновляем бюджет
        //            mainPresenter.Customer.ClearShoppingBasket();
        //            mainPresenter.UpdateShoppingCartView();
        //            mainPresenter.UpdateTotalAmount();
        //        }

        //        // Проверяем наличие средств на карте
        //        if (cardAmount > 0 && userBudget >= cardAmount)
        //        {
        //            mainPresenter.SetUserBudget(userBudget - cardAmount);
        //            remainingAmount -= cardAmount;
        //            mainPresenter.UpdateBudgetAfterPayment(totalAmount); // Обновляем бюджет
        //            mainPresenter.Customer.ClearShoppingBasket();
        //            mainPresenter.UpdateShoppingCartView();
        //            mainPresenter.UpdateTotalAmount();
        //        }

        //        if (remainingAmount == 0)
        //        {
        //            mainPresenter.Customer.ClearShoppingBasket();
        //            mainPresenter.UpdateShoppingCartView();
        //            mainPresenter.UpdateTotalAmount();
        //            OnPaymentCompleted();
        //            MessageBox.Show("Оплата частично успешно выполнена.");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Недостаточно средств для оплаты указанными способами.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Недостаточно средств для оплаты частично.");
        //    }
        //}
    }
}
