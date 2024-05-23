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
        public void OpenCvcVerificationForm()
        {
            CvcVerificationForm cvcVerificationForm = new CvcVerificationForm();
            cvcVerificationForm.PaymentPresenter = this;
            cvcVerificationForm.ShowDialog();
        }

        public void OpenCashPaymentForm(decimal totalAmount)
        {
            CashForm cashPaymentForm = new CashForm
            {
                PaymentPresenter = this,
                TotalAmount = totalAmount
            };
            cashPaymentForm.ShowDialog();
        }
        public void ProcessCashPayment(decimal totalInsertedAmount)
        {
            if (totalInsertedAmount >= mainPresenter.TotalAmountValue)
            {
                SetPaymentStrategy(new CashPaymentStrategy(mainPresenter, this));
                Pay();
            }
            else
            {
                MessageBox.Show("Недостаточно средств для оплаты наличными.");
            }
        }

        public void ProcessCardPayment(string cvcNumber)
        {
            if (cvcNumber.Length == 3 && cvcNumber.All(char.IsDigit))
            {
                // Оплата картой и прочие действия
               SetPaymentStrategy(new CardPaymentStrategy(mainPresenter, this));


                PaymentCompleted?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Введите корректный CVC номер.");
            }
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
    }
}
