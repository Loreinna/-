using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using Курсовая.Interface;
using Курсовая.Models;

namespace Курсовая.Presenters
{
    public class MainPresenter : IMainPresenter, ISubject
    {
        public Customer Customer;
        private readonly ListBox ProductList;
        private readonly ListBox ShoppingCartList;
        private List<IObserver> observers = new List<IObserver>();
        public Label TotalAmountLabel { get; set; }
        public Label TotalAmountLabelPay { get; set; }
        public Label BonusLabel { get; set; }
        public decimal TotalAmountValue { get; set; }

        public bool isPayByBonus;
        public int bonusPoints { get; set; }
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
            Customer = customer;
            ProductList = productList;
            ShoppingCartList = shoppingCartList;
            TotalAmountLabel = totalAmountLabel;
            productRepository = new ProductRepository();
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

            if (product != null)
            {
                if (product.RequiresWeighing)
                {
                    GetUserWeight(); // Запрашиваем у пользователя вес товара
                    product.Weight = userWeight;
                    product.WeighItem(); // Вызываем метод взвешивания товара
                }
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




        // Метод для передачи бюджета в представление
        public decimal GetUserBudgetLabel()
        {
            return UserBudget;
        }
        //Вычитаем из бюджета
        public void SetUserBudget(decimal budget)
        {
            UserBudget = budget;

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
            if (product.RequiresWeighing && !product.IsWeighed)
            {
                MessageBox.Show("Товар нужно взвесить перед добавлением в корзину.");
            }
            else
            {
                Product productCopy = CreateProductCopy(product);
                Customer.AddToShoppingBasket(productCopy);
                UpdateShoppingCartView(); // Обновляем представление корзины
                UpdateTotalAmount(); // Обновляем итоговую сумму
            }
        }
        // Метод для создания копии продукта с определенными свойствами
        private Product CreateProductCopy(Product product)
        {
            return new Product
            {
                Name = product.Name,
                Price = product.Price,
                Weight = product.Weight,
                RequiresWeighing = product.RequiresWeighing,
                ImagePath = product.ImagePath
            };
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
            TotalAmountLabel.Text = $"{totalAmount} руб.";
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