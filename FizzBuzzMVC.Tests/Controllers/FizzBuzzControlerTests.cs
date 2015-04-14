using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzMVC.Controllers;

namespace FizzBuzzMVC.Tests.Controllers
{
    [TestClass]
    public class FizzBuzzControlerTests
    {
        [TestMethod]
        public void Given1Return1()
        {
            var controller = new FizzBuzzController();
            var result = controller.Index(1) as ViewResult;

            var expected = "1 ";
            string actual = result.ViewBag.Output;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Given3Return12Fizz()
        {
            var controller = new FizzBuzzController();
            var result = controller.Index(3) as ViewResult;

            var expected = "1 2 Fizz ";
            string actual = result.ViewBag.Output;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Given5Return12Fizz4Buzz()
        {
            var controller = new FizzBuzzController();
            var result = controller.Index(5) as ViewResult;

            var expected = "1 2 Fizz 4 Buzz ";
            string actual = result.ViewBag.Output;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Given15()
        {
            var controller = new FizzBuzzController();
            var result = controller.Index(15) as ViewResult;

            var expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ";
            string actual = result.ViewBag.Output;

            Assert.AreEqual(expected, actual);

        }

    }
}
