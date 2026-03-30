using Microsoft.AspNetCore.Mvc;

namespace Assignment_4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.StudentName = "Pranav Surwase";
            ViewData["Age"] = 23;
            return View();
        }

    }
}
