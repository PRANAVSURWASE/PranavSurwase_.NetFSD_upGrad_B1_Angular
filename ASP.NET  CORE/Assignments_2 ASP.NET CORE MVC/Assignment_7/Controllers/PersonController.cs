using Assignment_7.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_7.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person person)
        {

            if(ModelState.IsValid)
            {
                ViewBag.Message = "Form Submitted suceessFully";
            }


            return View(person);
        }
    }
}
