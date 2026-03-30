using Assignment_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Pranav Surwase",
                Age = 23,
                Email = "pranavsurwase93@gmail.com"
            };
            return View(student);
        }
    }
}
