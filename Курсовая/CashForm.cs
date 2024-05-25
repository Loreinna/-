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
using Курсовая.Presenters;

namespace Курсовая
{
    public partial class CashForm : Form
    {
        public PaymentPresenter PaymentPresenter { get; set; }
        public decimal TotalAmount { get; set; }
        private decimal totalInsertedAmount;
        private decimal changeAmount;

        public CashForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(CashPaymentForm_Load);

        }

        private void CashPaymentForm_Load(object sender, EventArgs e)
        {

            TotalLabel.Text = TotalAmount.ToString();
            DenominationComboBox.Items.AddRange(new object[] { 1000, 500, 100, 50, 10, 5, 1 });
            DenominationComboBox.SelectedIndex = 0;
            UpdateTotalInsertedAmountLabel();
        }

        private void AddBillButton_Click(object sender, EventArgs e)
        {
            if (DenominationComboBox.SelectedItem != null)
            {
                int denomination = (int)DenominationComboBox.SelectedItem;
                InsertedBillsListBox.Items.Add(denomination);
                totalInsertedAmount += denomination;
                UpdateTotalInsertedAmountLabel();
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (totalInsertedAmount >= TotalAmount)
            {
                changeAmount = totalInsertedAmount - TotalAmount;
                PaymentPresenter.ProcessCashPayment(totalInsertedAmount);
                ShowChange();
                this.Close();
            }
            else
            {
                MessageBox.Show("Недостаточно средств. Пожалуйста, вставьте больше купюр.");
            }
        }

        private void UpdateTotalInsertedAmountLabel()
        {
            TotalInsertedAmountLabel.Text = $"Общая сумма вставленных купюр: {totalInsertedAmount} руб.";
        }
        private void ShowChange()
        {
            MessageBox.Show($"Оплачено наличными. Сумма: {TotalAmount} руб.\nСдача: {changeAmount} руб.");
        }
    }
}

