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
    public partial class CvcVerificationForm : Form
    {
        public PaymentPresenter PaymentPresenter { get; set; }
        public CvcVerificationForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            string cvcNumber = CvcTextBox.Text;
            if (cvcNumber.Length == 3 && cvcNumber.All(char.IsDigit))
            {
                // Оплата картой и прочие действия
                PaymentPresenter.ProcessCardPayment(cvcNumber);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите корректный CVC номер.");
                CvcTextBox.Clear(); // Очищаем TextBox для повторного ввода
                CvcTextBox.Focus();
            }

        }
    }
}
