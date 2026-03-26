using Microsoft.AspNetCore.Mvc;

namespace Assignment_3.Controllers
{
    public class UserController : Controller
    {
       /* public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult Details(string name,int age)
        {
            return Content($"Name :{name} Age :{age}");
        }
    }
}
