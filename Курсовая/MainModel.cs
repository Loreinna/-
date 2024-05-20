using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая.Interface;

namespace Курсовая
{
    public class Product : IWeighable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public bool RequiresWeighing { get; set; } // Необходимость взвешивания
        public bool IsWeighed { get; set; } // Товар был взвешен
        public string ImagePath { get; set; }

        public Product(string name, decimal price, decimal weight, bool requiresWeighing, string imagePath)
        {
            Name = name;
            Price = price;
            Weight = weight;
            RequiresWeighing = requiresWeighing;
            ImagePath = imagePath;
            IsWeighed = false;
        }

        public bool WeighItem()
        {
            if (RequiresWeighing)
            {
                Price = Math.Round(Weight * Price);
                IsWeighed = true;
                // Логика взвешивания товара
                MessageBox.Show($"Товар \"{Name}\" успешно взвешен.");
                return true;
            }
            else
            {
                MessageBox.Show($"Товар \"{Name}\" не требует взвешивания.");
                return false;
            }
        }


    }
    public class ProductRepository
    {
        public List<Product> Products { get; set; }

        public ProductRepository()
        {
            Products = new List<Product>();
            LoadProducts(); // Загружаем продукты
        }

        public void LoadProducts()
        {
            // Добавление продуктов в список
            Products.Add(new Product("Мука ", 50, 1.2m, false,"Images\\мука.jpg"));
            Products.Add(new Product("Сахар", 45, 1.0m, false ,"Images\\сахар.jpg"));
            Products.Add(new Product("Пшеничный хлеб", 25, 0.3m, false,"Images\\хлеб пшеничный.jpg"));
            Products.Add(new Product("Молоко", 60, 1.0m, false, "Images\\молоко.jpg"));
            Products.Add(new Product("Куриное филе", 120, 0.7m, true,"Images\\куриное филе.png"));
            Products.Add(new Product("Яблоки", 70, 1.5m, true, "Images\\яблоки.jpg"));
            Products.Add(new Product("Картофель", 30, 2.0m, true,"Images\\картофель.jpg"));
            Products.Add(new Product("Помидоры", 90, 1.0m, true,"Images\\помидоры.jpg"));
            Products.Add(new Product("Огурцы", 80, 1.0m, true,"Images\\огурцы.png"));
            Products.Add(new Product("Сыр", 200, 0.5m, false, "Images\\сыр.jpg"));
            Products.Add(new Product("Йогурт", 35, 0.2m, false,"Images\\йогурт.png"));

        }
    }
    public class Customer
    {
        public string BonusCard { get; set; }
        public decimal Wallet { get; set; }
        public List<Product> ShoppingBasket { get; set; }
        public int BonusPoints { get; set; }

        public Customer()
        {
            ShoppingBasket = new List<Product>();

        }
        public void ClearShoppingBasket()
        {
            ShoppingBasket.Clear();
        }
        public int GetBonusPoints(MainPresenter mainPresenter)
        {
            return mainPresenter.bonusPoints;
        }

        public void AddToShoppingBasket(Product product)
        {
            ShoppingBasket.Add(product);
        }

        public void RemoveFromShoppingBasket(Product product)
        {
            ShoppingBasket.Remove(product);
        }
    }
}
