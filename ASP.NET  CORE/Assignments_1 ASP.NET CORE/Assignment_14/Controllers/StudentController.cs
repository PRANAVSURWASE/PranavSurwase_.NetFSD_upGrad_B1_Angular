using Microsoft.AspNetCore.Mvc;

namespace Assignment_14.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            List<string> students = new List<string>()
            {
                "Pranav Surwase",
                "Vaibhav Jadhav",
                "Shriraj Thavare"
            };
            ViewData["students"] = students;

            return View();
        }
    }
}
