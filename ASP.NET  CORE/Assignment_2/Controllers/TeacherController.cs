using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    public class TeacherController : Controller
    {
       /* public IActionResult Index()
        {
            return View();
        }*/
       public string Index()
        {
            return "Teacher Home Page";
        }

        public string Details()
        {
            return "Teacher Details Page";
        }
    }
}
