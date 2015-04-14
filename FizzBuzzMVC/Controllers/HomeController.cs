using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FizzBuzzMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _repo;

        public HomeController(IProductRepository repo)
        {
            _repo = repo;
        }

        public HomeController()
        {
            _repo = new ProductRepository();
        }
        public ViewResult Index()
        {
            var products = _repo.GetAll();
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAll()
        {
            return null;
        }
    }

    public interface IProductRepository
    {
        List<Product> GetAll();
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}