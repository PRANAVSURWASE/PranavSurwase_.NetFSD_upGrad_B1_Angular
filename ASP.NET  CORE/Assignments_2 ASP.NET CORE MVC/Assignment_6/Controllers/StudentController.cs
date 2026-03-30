using Microsoft.AspNetCore.Mvc;
using Assignment_6.Models;
namespace Assignment_6.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Pranav", Age = 23, Email = "pranav@gmail.com" },
            new Student { Id = 2, Name = "Rahul", Age = 22, Email = "rahul@gmail.com" }
        };


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                student.Id = students.Any() ? students.Max(s => s.Id) + 1 : 1;
                students.Add(student);
                return RedirectToAction("Index");
            }
            return View(student);

        }
    }
}
