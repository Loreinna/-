using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая.Interface;
using Курсовая.Presenters;

namespace Курсовая.Models
{
    public class Product : IWeighable
    {
        public string Name { get; set; }
        public decimal price;
        public decimal Price { 
            get {
                if (RequiresWeighing)
                    return Math.Round(Weight * price, 2);
                else return price;
            } 
            set { this.price = value;}
        }
        public decimal Weight { get; set; }
        public bool RequiresWeighing { get; set; } // Необходимость взвешивания
        public bool IsWeighed { get; set; } // Товар был взвешен
        public string ImagePath { get; set; }
        public string NameAndPrice => $"{Name} - {price} руб.";
        public Product(string name, decimal price, bool requiresWeighing, string imagePath)
        {
            Name = name;
            Price = price;
            RequiresWeighing = requiresWeighing;
            ImagePath = imagePath;
            IsWeighed = false;
            //Price = Math.Round(Weight * Price, 2);
        }

        public bool WeighItem()
        {
            if (RequiresWeighing)
            {
                //Price = Math.Round(Weight * Price,2);
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
        // Пустой конструктор для создания экземпляра продукта без передачи свойств
        public Product()
        {
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
            Products.Add(new Product("Мука ", 80, false, "Images\\мука.jpg"));
            Products.Add(new Product("Сахар", 60, false, "Images\\сахар.jpg"));
            Products.Add(new Product("Пшеничный хлеб", 70, false, "Images\\хлеб пшеничный.jpg"));
            Products.Add(new Product("Молоко", 73, false, "Images\\молоко.jpg"));
            Products.Add(new Product("Куриное филе", 400, true, "Images\\куриное филе.png"));
            Products.Add(new Product("Яблоки", 70, true, "Images\\яблоки.jpg"));
            Products.Add(new Product("Картофель", 20, true, "Images\\картофель.jpg"));
            Products.Add(new Product("Помидоры", 177, true, "Images\\помидоры.jpg"));
            Products.Add(new Product("Огурцы", 115, true, "Images\\огурцы.png"));
            Products.Add(new Product("Сыр", 255, false, "Images\\сыр.jpg"));
            Products.Add(new Product("Йогурт", 35, false, "Images\\йогурт.png"));
            //Products.Add(new Product("Сок апельсиновый", 100, false, "Images\\сок апельсиновый.jpg"));
            //Products.Add(new Product("Масло сливочное", 90, false, "Images\\масло сливочное.jpg"));
            //Products.Add(new Product("Бананы", 60, true, "Images\\бананы.jpg"));
            //Products.Add(new Product("Кофе молотый", 220, false, "Images\\кофе.jpg"));
            //Products.Add(new Product("Сок яблочный", 65, false, "Images\\сок яблочный.jpg"));
            //Products.Add(new Product("Мясо говядины", 450, true, "Images\\говядина.jpg"));
            //Products.Add(new Product("Рис", 89, false, "Images\\рис.jpg"));
            //Products.Add(new Product("Спагетти", 67, false, "Images\\спагетти.jpg"));
            //Products.Add(new Product("Оливковое масло", 450, false, "Images\\оливковое масло.jpg"));
            //Products.Add(new Product("Туалетная бумага", 70, false, "Images\\туалетная бумага.jpg"));
            //Products.Add(new Product("Зубная паста", 120, false, "Images\\зубная паста.jpg"));
            //Products.Add(new Product("Шампунь", 300, false, "Images\\шампунь.jpg"));
            //Products.Add(new Product("Куриное яйцо", 100, false, "Images\\яйцо.jpg"));
            //Products.Add(new Product("Шоколад", 120, false, "Images\\шоколад.jpg"));
            //Products.Add(new Product("Мыло", 50, false, "Images\\мыло.jpg"));

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

        public void RemoveFromShoppingBasket(int index)
        {
            ShoppingBasket.RemoveAt(index);
        }
    }
}
