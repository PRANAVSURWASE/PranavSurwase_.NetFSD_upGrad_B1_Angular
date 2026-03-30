using Microsoft.AspNetCore.Mvc;

namespace Assignment_4.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetProduct(int id)
        {
            return Content($"ProductId :{id}");
        }
    }
}
