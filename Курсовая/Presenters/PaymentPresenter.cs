using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая.Interface;
using Курсовая.Models;

namespace Курсовая.Presenters
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
            }
            else
            {
                MessageBox.Show("Недостаточно средств для оплаты наличными.");
            }
        }

        public void ProcessCardPayment(string cvcNumber)
        {
                SetPaymentStrategy(new CardPaymentStrategy(mainPresenter, this));
            
        }
        public PaymentPresenter(Customer customer, MainPresenter mainPresenter)
        {

            Сustomer = customer;
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
