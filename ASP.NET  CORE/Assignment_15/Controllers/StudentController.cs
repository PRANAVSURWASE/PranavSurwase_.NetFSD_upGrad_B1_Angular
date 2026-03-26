using Microsoft.AspNetCore.Mvc;

namespace Assignment_15.Controllers
{
    public class StudentController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult Details(string name,int age)
        {
            ViewData["Name"] = name;
            ViewData["Age"] = age;

            ViewData["Message"] = "Student Infformation Page";
            return View();
        }
    }
}
