using Microsoft.AspNetCore.Mvc;

namespace Assignment_10.Controllers
{
    public class EmployeeController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult Details()
        {
            ViewData["Name"] = "Pranav Surwase";
            ViewData["Salary"] = 32000;
            ViewData["Department"] = "IT";
            return View();
        }
    }
}
