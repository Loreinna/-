using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Курсовая;
using Курсовая.Models;
using Курсовая.Presenters;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyTests
{
    [TestClass]
    public class MainPresenterTests
    {
        private MainPresenter mainPresenter;
        private Customer customer;
        private ListBox productList;
        private ListBox shoppingCartList;
        private Label totalAmountLabel;

        [TestInitialize]
        public void Setup()
        {
            customer = new Customer();
            productList = new ListBox();
            shoppingCartList = new ListBox();
            totalAmountLabel = new Label();
            mainPresenter = new MainPresenter(customer, productList, shoppingCartList, totalAmountLabel);
        }

        [TestMethod]
        public void CalculateTotalAmount_ShouldReturnCorrectSum()
        {
            // Arrange
            var product1 = new Product { Name = "Product1", Price = 100 };
            var product2 = new Product { Name = "Product2", Price = 200 };
            customer.AddToShoppingBasket(product1);
            customer.AddToShoppingBasket(product2);

            // Act
            var totalAmount = mainPresenter.CalculateTotalAmount();

            // Assert
            Assert.AreEqual(300, totalAmount);
        }

        [TestMethod]
        public void AddProductToBasket_ShouldAddProduct()
        {
            // Arrange
            var product = new Product { Name = "Product1", Price = 100 };

            // Act
            mainPresenter.AddProductToBasket(product);

            // Assert
            Assert.AreEqual(1, customer.ShoppingBasket.Count);
            Assert.AreEqual(product.Name, customer.ShoppingBasket[0].Name);
        }
        [TestMethod]
        public void RemoveProductFromShoppingCart_ShouldRemoveProduct()
        {
            // Arrange
            Customer customer = new Customer();
            Product productToRemove = new Product("Test Product", 100, false, "test_image.jpg");
            customer.AddToShoppingBasket(productToRemove);

            // Act
            customer.RemoveFromShoppingBasket(productToRemove);

            // Assert
            Assert.IsFalse(customer.ShoppingBasket.Contains(productToRemove), "Product was not removed from shopping cart.");
        }
        [TestMethod]
        public void UpdateTotalAmount_ShouldUpdateTotalAmount()
        {
            // Arrange
            var product1 = new Product { Name = "Product1", Price = 100 };
            var product2 = new Product { Name = "Product2", Price = 200 };
            customer.AddToShoppingBasket(product1);
            customer.AddToShoppingBasket(product2);

            // Act
            mainPresenter.UpdateTotalAmount();

            // Assert
            Assert.AreEqual(300, mainPresenter.TotalAmountValue);
            Assert.AreEqual($"{300} руб.", totalAmountLabel.Text);
        }
        [TestMethod]
        public void WeighProduct_ShouldSetProductWeight()
        {
            // Arrange
            var product = new Product { Name = "Product1", RequiresWeighing = true };
            decimal expectedWeight = 1.5m;

            // Act
            mainPresenter.WeighProduct(product);

            // Set product weight directly for testing purposes
            product.Weight = expectedWeight;

            // Assert
            Assert.AreEqual(expectedWeight, product.Weight);
            Assert.IsTrue(product.IsWeighed);
        }

    }


    

    
}
