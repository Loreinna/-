using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using Курсовая.Interface;

namespace Курсовая
{
    public class MainPresenter : IMainPresenter, ISubject
    {
        public Customer Customer;
        private readonly ListBox ProductList;
        private readonly ListBox ShoppingCartList;
        private List<IObserver> observers = new List<IObserver>();
        public Label TotalAmountLabel { get; set; }
        public Label TotalAmountLabelPay { get; set; }
        public Label BonusLabel {  get; set; }
        public decimal TotalAmountValue { get; set; }

        public bool isPayByBonus;
        public int bonusPoints{get; set; }
        private readonly ProductRepository productRepository;
        private decimal UserBudget;
        private decimal userWeight;
        //private readonly MainForm mainForm;

        //public MainPresenter(MainForm mainForm)
        //{
        //    this.mainForm = mainForm;
        //}

        public MainPresenter(Customer customer, ListBox productList, ListBox shoppingCartList, Label totalAmountLabel)
        {
            this.Customer = customer;
            this.ProductList = productList;
            this.ShoppingCartList = shoppingCartList;
            this.TotalAmountLabel = totalAmountLabel;
            this.productRepository = new ProductRepository();
            BonusLabel = new Label();
            LoadProducts();
            GetUserBudget();
            bonusPoints = CalculateBonusPoints(UserBudget);
            isPayByBonus = false;


        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(decimal newBudget)
        {
            foreach (var observer in observers)
            {
                observer.Update(newBudget);
            }
        }

        public void UpdateBudgetAfterPayment(decimal totalAmount)
        {
            Notify(UserBudget);
            isPayByBonus = false;
        }

        public void LoadProducts()
        {
            if (productRepository != null)
            {
                ProductList.Items.Clear();

                foreach (Product product in productRepository.Products)
                {
                    ProductList.Items.Add(product);
                }
            }
        }

        public void WeighProduct(Product product)
        {
            GetUserWeight(); // Запрашиваем у пользователя вес товара
            if (product != null && product.RequiresWeighing)
            {
                product.Weight = userWeight;
                product.WeighItem(); // Вызываем метод взвешивания товара
                product.RequiresWeighing = false;
            }
            else if (product != null && !product.RequiresWeighing)
            {
                MessageBox.Show($"Товар \"{product.Name}\" не требует взвешивания.");
            }
            else
            {
                MessageBox.Show("Выберите товар для взвешивания.");
            }
        }
        //Метод для бюджета
        public void GetUserBudget()
        {
            string inputBudget = Interaction.InputBox("Введите ваш бюджет:", "Бюджет", "1000");
            if (!decimal.TryParse(inputBudget, out UserBudget))
            {
                MessageBox.Show("Некорректный формат бюджета! Используйте только цифры.");
                GetUserBudget(); // Повторяем запрос бюджета, если был введен некорректный формат
            }
        }

        public void GetUserWeight()
        {
            string inputWeightGrams = Interaction.InputBox("Введите вес товара (в граммах):", "Вес", "1000");
            if (!decimal.TryParse(inputWeightGrams, out decimal weightGrams) || weightGrams <= 0)
            {
                MessageBox.Show("Некорректный формат веса! Используйте положительное число.");
                GetUserWeight(); // Повторяем запрос веса, если был введен некорректный формат
            }
            else
            {
                // Пересчитываем вес из граммов в килограммы
                userWeight = weightGrams / 1000;
            }
        }


        // Метод для передачи бюджета в представление
        public decimal GetUserBudgetLabel()
        {
            return UserBudget;
        }
        //Вычитаем из бюджета
        public void SetUserBudget(decimal budget)
        {
            this.UserBudget = budget;

        }

        public void InitializeCustomer()
        {
            Customer = new Customer();
        }
        //Апдейтим бюджет
        public void UpdateTotalAmount()
        {
            TotalAmountValue = CalculateTotalAmount();

            TotalAmountLabel.Text = $"{TotalAmountValue} руб.";
            //BonusLabel.Text = $"{bonusPoints}";
            //надо думать
            if (TotalAmountLabelPay != null)
            TotalAmountLabelPay.Text = $"{TotalAmountValue} руб.";
        }
        public void AddProductToBasket(Product product)
        {
            if (product.RequiresWeighing)
            {
                MessageBox.Show("Товар нужно взвесить перед добавлением в корзину.");
            }
            else
            {
                Customer.AddToShoppingBasket(product);
                UpdateShoppingCartView(); // Обновляем представление корзины
                UpdateTotalAmount(); // Обновляем итоговую сумму
            }
        }

        public void RemoveProductFromBasket(Product product)
        {
            Customer.RemoveFromShoppingBasket(product);
            UpdateShoppingCartView();
            UpdateTotalAmount();
        }

        public void PayForBasket()
        {
            decimal totalAmount = CalculateTotalAmount();
            TotalAmountLabel.Text = $"Итого: {totalAmount} руб.";
        }

        public decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (Product product in Customer.ShoppingBasket)
            {
                totalAmount += product.Price;
            }
            return totalAmount;
        }

        public int CalculateBonusPoints(decimal userBudget)
        {
            // Рассчитываем максимальное количество бонусных очков (число округляем до целого числа)
            int maxBonusPoints = (int)(userBudget / 4);

            // Генерируем случайное количество бонусных очков в диапазоне от 1 до максимального значения
            Random random = new Random();
            int GeneratedbonusPoints = random.Next(1, maxBonusPoints + 1);

            return GeneratedbonusPoints;
        }


        public void UpdateShoppingCartView()
        {
            ShoppingCartList.Items.Clear();
            foreach (Product product in Customer.ShoppingBasket)
            {
                ShoppingCartList.Items.Add($"{product.Name} - {product.Price} руб.");
            }
            UpdateTotalAmount(); // Обновляем итоговую сумму
        }
    }
}