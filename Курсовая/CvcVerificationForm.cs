using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            PaymentPresenter.ProcessCardPayment(cvcNumber);
            this.Close(); // Закрываем форму после подтверждения оплаты
        }
    }
}
