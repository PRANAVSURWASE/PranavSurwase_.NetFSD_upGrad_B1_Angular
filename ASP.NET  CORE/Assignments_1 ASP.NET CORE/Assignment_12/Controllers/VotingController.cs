using Microsoft.AspNetCore.Mvc;

namespace Assignment_12.Controllers
{
    public class VotingController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult Check()
        {
            ViewData["Age"] = 23;
            return View();
        }
    }
}
