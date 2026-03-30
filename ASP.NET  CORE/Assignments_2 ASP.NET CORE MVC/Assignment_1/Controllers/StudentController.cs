using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment_1.Controllers
{
    public class StudentController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        public string Index()
        {
            return "Welcome to Student Page";
        }
        public string Details()
        {
            return "Student Details Page";
        }
        public IActionResult GetStudent(int id)
        {
            ViewBag.StudentId = id;

            return View();
        }
    }
}
