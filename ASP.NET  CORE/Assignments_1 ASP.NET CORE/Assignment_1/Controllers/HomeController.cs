using Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Index()
        {
            return Content("Welcome  to ASP.NET CORE MVC");
        }
        public IActionResult About()
        {
            return Content("This is About Page");
        }
        public IActionResult Contact()
        {
            return Content("Contact us at support@test.com");
        }
    }
}
