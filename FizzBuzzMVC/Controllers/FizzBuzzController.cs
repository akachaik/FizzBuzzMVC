using System.Web.Mvc;

namespace FizzBuzzMVC.Controllers
{
    public class FizzBuzzController : Controller
    {
        public ActionResult Index(int number)
        {


            for (var i = 1; i <= number; i++)
            {
                if (i % 5 == 0 && i % 3  == 0)
                {
                    ViewBag.Output += "FizzBuzz ";
                }
                else if (i%5 == 0)
                {
                    ViewBag.Output += "Buzz ";
                }
                else if (i%3 == 0)
                {
                    ViewBag.Output += "Fizz ";
                }
                else
                {
                    ViewBag.Output += i + " ";

                }
            }
            return View();
        }
    }
}