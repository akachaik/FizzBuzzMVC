using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzMVC;
using FizzBuzzMVC.Controllers;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;

namespace FizzBuzzMVC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        [TestMethod]
        public void IndexReturnAllProduct()
        {
            var mockProduct = Mock.Create<IProductRepository>();
            Mock.Arrange(() => mockProduct.GetAll()).Returns(new List<Product>()
            {
                new Product() { Id = 1, Name = "Product 1", Price =  100m},
                new Product() { Id = 2, Name = "Product 2", Price =  200m},
                new Product() { Id = 3, Name = "Product 3", Price =  300m}
            }).MustBeCalled();

            var controller = new HomeController(mockProduct);

            var result = controller.Index();
            var model = result.Model as IEnumerable<Product>;

            Assert.AreEqual(3, model.Count());
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
