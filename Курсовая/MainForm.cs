using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Курсовая.Interface;
using Курсовая.Models;
using Курсовая.Presenters;

namespace Курсовая
{
    public partial class MainForm : Form, IObserver
    {
        private readonly MainPresenter mainpresenter;
        private PaymentPresenter Paypresenter;
        PaymentForm paymentForm;
        public MainForm()
        {
            InitializeComponent();
            Customer customer = new Customer();
            mainpresenter = new MainPresenter(customer, new ListBox(), new ListBox(), new Label());
            mainpresenter.Attach(this); // Подписываем форму как наблюдателя

            BudgetLabel.Text = $"{mainpresenter.GetUserBudgetLabel()}";
            BonusLabel.Text = $"{mainpresenter.bonusPoints}";
            ProductRepository productRepository = new ProductRepository(); // Привязываем данные из ProductRepository к ProductList на форме
            ProductList.DataSource = productRepository.Products;
            ProductList.DisplayMember = "NameAndPrice";
            mainpresenter.TotalAmountLabel = TotalAmountLabel;
            mainpresenter.InitializeCustomer();

            this.Paypresenter = new PaymentPresenter(mainpresenter.Customer, mainpresenter);

            // Подписываемся на событие PaymentCompleted
            Paypresenter.PaymentCompleted += Paypresenter_PaymentCompleted;

            ProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void ShowProductImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                ProductPictureBox.ImageLocation = imagePath;
            }
            else
            {
                
                ProductPictureBox.Image = null;
            }
        }
        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductList.SelectedItem != null && ProductList.SelectedItem is Product selectedProduct)
            {
                
                ShowProductImage(selectedProduct.ImagePath);
            }
        }
        public void Update(decimal newBudget)
        {
            BudgetLabel.Text = newBudget.ToString();
            paymentForm.BudgetLabel.Text = newBudget.ToString();


            if (!string.IsNullOrEmpty(mainpresenter.BonusLabel.Text))
                BonusLabel.Text = mainpresenter.BonusLabel.Text;
        }
        private void Paypresenter_PaymentCompleted(object sender, EventArgs e)
        {
            ShoppingCartList.Items.Clear();
            mainpresenter.UpdateTotalAmount();

        }

        public void UpdateBudgetLabel(decimal newBudget)
        {
            BudgetLabel.Text = $"Ваш бюджет: {newBudget} руб.";

        }

        public void UpdateShoppingCartView()
        {
            ShoppingCartList.Items.Clear();

            if (mainpresenter.Customer != null && mainpresenter.Customer.ShoppingBasket != null)
            {
                foreach (Product product in mainpresenter.Customer.ShoppingBasket)
                {
                    ShoppingCartList.Items.Add($"{product.Name} - {product.Price} руб.");
                }
            }

            mainpresenter.UpdateTotalAmount(); 
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Product selectedProduct = GetSelectedProduct();

            if (selectedProduct != null)
            {
                if (selectedProduct.RequiresWeighing && !selectedProduct.IsWeighed)
                {
                    MessageBox.Show("Для этого продукта необходимо взвешивание.");
                }
                else
                {
                    int quantity = (int)QuantityNumericUpDown.Value;
                    for (int i = 0; i < quantity; i++)
                    {
                        mainpresenter.AddProductToBasket(selectedProduct);
                    }
                    UpdateShoppingCartView();
                    mainpresenter.UpdateTotalAmount();
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для добавления в корзину.");
            }
        }

        private void RemoveFromCartButton_Click(object sender, EventArgs e)
        {

            if (ShoppingCartList.SelectedIndex != -1)
            {
                mainpresenter.RemoveProductFromBasket(ShoppingCartList.SelectedIndex);
                UpdateShoppingCartView();
                mainpresenter.UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Выберите продукт для удаления из корзины.");
            }
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            paymentForm = new PaymentForm(Paypresenter, mainpresenter);

            paymentForm.TotalAmountLabel.Text = TotalAmountLabel.Text;
            paymentForm.BudgetLabel.Text = mainpresenter.GetUserBudgetLabel().ToString();
            paymentForm.BonusLabel.Text = BonusLabel.Text;
            mainpresenter.TotalAmountLabelPay = paymentForm.TotalAmountLabel;
            paymentForm.Show();
        }
        private void WeighButton_Click(object sender, EventArgs e)
        {
            Product selectedProduct = GetSelectedProduct();

            if (selectedProduct != null && selectedProduct.RequiresWeighing)
            {
                mainpresenter.WeighProduct(selectedProduct);
                mainpresenter.AddProductToBasket(selectedProduct);
                UpdateShoppingCartView(); 
            }
            else
            {
                MessageBox.Show("Выберите товар для взвешивания.");
            }
        }

        public Product GetSelectedProduct()
        {
            if (ProductList.SelectedItem != null && ProductList.SelectedItem is Product)
            {

                return (Product)ProductList.SelectedItem;
            }
            else
            {
                return null;
            }
        }


    }
}