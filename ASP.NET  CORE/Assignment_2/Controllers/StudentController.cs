using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    public class StudentController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        public string Index()
        {
            return "Student Home Page";
        }
        public string Profile()
        {
            return "Student Profile Page ";
        }
    }
}
