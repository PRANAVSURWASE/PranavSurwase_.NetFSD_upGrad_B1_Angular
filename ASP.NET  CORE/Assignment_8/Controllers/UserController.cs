using Microsoft.AspNetCore.Mvc;

namespace Assignment_8.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Pranav Surwase";
            ViewData["Age"] = 23;
            return View();
        }

    }
}
