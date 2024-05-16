using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.Interface;

namespace Курсовая
{
    public partial class PaymentForm : Form
    {
        private PaymentPresenter Paypresenter;
        private MainPresenter mainPresenter;
        private IPaymentStrategy paymentStrategy;
        private int bonusPoints;





        public PaymentForm(string totalAmount, PaymentPresenter presenter, MainPresenter mainPresenter, decimal budget, int bonusPoints)
        {
            InitializeComponent();
            TotalAmountLabel.Text = totalAmount;
            this.Paypresenter = presenter;
            BudgetLabel.Text = budget.ToString();
            BonusLabel.Text = bonusPoints.ToString();  // Инициализируем поле BonusLabel


            if (mainPresenter != null)
            {
                this.mainPresenter = mainPresenter;
            }
            else
            {
                // Обработка случая, когда mainPresenter равен null
                MessageBox.Show("Ошибка: отсутствует главный презентер. Пожалуйста, свяжитесь с администратором.");

            }

        }


        private void PayButton_Click(object sender, EventArgs e)
        {
            if (CashRadioButton.Checked)
            {
                Paypresenter.SetPaymentStrategy(new CashPaymentStrategy(mainPresenter, Paypresenter));
            }
            else if (CardRadioButton.Checked)
            {
                Paypresenter.SetPaymentStrategy(new CardPaymentStrategy(mainPresenter, Paypresenter));
            }
            else if (BonusRadioButton.Checked)
            {
                Paypresenter.SetPaymentStrategy(new BonusPaymentStrategy(mainPresenter, Paypresenter, BonusLabel));

            }
            else if (PayPartRadioButton.Checked)
            {
                if (!string.IsNullOrEmpty(CashAmountTextBox.Text) && !string.IsNullOrEmpty(CardAmountTextBox.Text))
                {
                    // Проверяем, успешно ли произведен парсинг сумм
                    if (decimal.TryParse(CashAmountTextBox.Text, out decimal cashAmount) && decimal.TryParse(CardAmountTextBox.Text, out decimal cardAmount))
                    {
                        // Обновляем стратегию частичной оплаты с новыми суммами
                        paymentStrategy = new PartialPaymentStrategy(mainPresenter, Paypresenter, cashAmount, cardAmount);

                        // Устанавливаем стратегию в PaymentPresenter
                        Paypresenter.SetPaymentStrategy(paymentStrategy);
                    }
                    else
                    {
                        MessageBox.Show("Некорректный формат суммы.");
                    }
                }
                else
                {
                    MessageBox.Show("Введите суммы для частичной оплаты наличными и картой.");
                }
            }
            else
            {
                MessageBox.Show("Выберите метод оплаты.");
            }

            // Выполняем оплату с помощью выбранной стратегии
            Paypresenter.Pay();
        }
    }
}
