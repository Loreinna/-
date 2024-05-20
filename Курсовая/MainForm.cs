using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Курсовая.Interface;

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
            // MainPresenter presenter = new MainPresenter(customer, new ListBox(), new ListBox(), new Label());
            Customer customer = new Customer();
            mainpresenter = new MainPresenter(customer, new ListBox(), new ListBox(), new Label());
            mainpresenter.Attach(this); // Подписываем форму как наблюдателя

            BudgetLabel.Text = $"Ваш бюджет: {mainpresenter.GetUserBudgetLabel()} руб.";// Отображаем бюджет пользователя на форме
            BonusLabel.Text = $"{mainpresenter.bonusPoints}";
            ProductRepository productRepository = new ProductRepository(); // Привязываем данные из ProductRepository к ProductList на форме
            ProductList.DataSource = productRepository.Products;
            ProductList.DisplayMember = "Name";
            mainpresenter.TotalAmountLabel = TotalAmountLabel;
            // Инициализируем Customer через presenter
            mainpresenter.InitializeCustomer();
            // Инициализируем Paypresenter
            this.Paypresenter = new PaymentPresenter(mainpresenter.Customer, mainpresenter);

            // Подписываемся на событие PaymentCompleted
            Paypresenter.PaymentCompleted += Paypresenter_PaymentCompleted;
            // Добавляем обработчик события SelectedIndexChanged к ProductList

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
                // Путь к изображению пустой или null, очищаем PictureBox
                ProductPictureBox.Image = null;
            }
        }
        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductList.SelectedItem != null && ProductList.SelectedItem is Product selectedProduct)
            {
                // Обновляем изображение продукта в PictureBox
                ShowProductImage(selectedProduct.ImagePath);
            }
        }
        public void Update(decimal newBudget)
        {
            BudgetLabel.Text = newBudget.ToString();
            paymentForm.BudgetLabel.Text = newBudget.ToString();


            if (!string.IsNullOrEmpty(mainpresenter.BonusLabel.Text))
                BonusLabel.Text = mainpresenter.BonusLabel.Text;
            //BonusLabel = mainpresenter.BonusLabel;
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

            mainpresenter.UpdateTotalAmount(); // Обновляем сумму в TotalAmountLabel

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
            Product selectedProduct = GetSelectedProduct();
            mainpresenter.RemoveProductFromBasket(selectedProduct);
            UpdateShoppingCartView();
            // После удаления продукта обновляем итоговую сумму
            mainpresenter.UpdateTotalAmount();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            //string totalAmountValue = TotalAmountLabel.Text; // Получаем значение из лейбла
            //decimal userBudget = mainpresenter.GetUserBudgetLabel();
            //int bonusPoints;
            //int a = int.Parse(BonusLabel.Text);
            //if (int.TryParse(BonusLabel.Text, out bonusPoints))
            //{
            // Используйте bonusPoints как целое число
            paymentForm = new PaymentForm(Paypresenter, mainpresenter);

            paymentForm.TotalAmountLabel.Text = TotalAmountLabel.Text;
            paymentForm.BudgetLabel.Text = mainpresenter.GetUserBudgetLabel().ToString();
            paymentForm.BonusLabel.Text = BonusLabel.Text;
            mainpresenter.TotalAmountLabelPay = paymentForm.TotalAmountLabel;
            paymentForm.Show(); // Показываем вторую форму
                                // }
        }

        private void WeighButton_Click(object sender, EventArgs e)
        {
            Product selectedProduct = GetSelectedProduct();

            if (selectedProduct != null)
            {
                mainpresenter.WeighProduct(selectedProduct);
                mainpresenter.AddProductToBasket(selectedProduct);
                UpdateShoppingCartView(); // Обновляем представление корзины после взвешивания
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