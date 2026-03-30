using Microsoft.AspNetCore.Mvc;

namespace Assignment_8.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            ViewData["Name"] = "Pranav";
            ViewData["Age"] = 23;

            return View();
        }
    }
}
