using Microsoft.AspNetCore.Mvc;

namespace Assignment_5.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int add(int a ,int b)
        {
            int add = a + b;
            return add;
            
           
        }

        public int multiply(int a, int b)
        {
            int res = a * b;
            return res;
        }

    }
}
