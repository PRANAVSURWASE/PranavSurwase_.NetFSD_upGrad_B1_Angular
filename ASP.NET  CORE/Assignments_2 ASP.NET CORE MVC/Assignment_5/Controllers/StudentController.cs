using Assignment_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_5.Controllers
{
    public class StudentController : Controller
    {

        private static List<Student> students = new List<Student>()
        {
            new Student{Id=1,Name="pranav",Age=23,Email="pranav@gmail.com"},
            new Student{Id=2,Name="pratik",Age=25,Email="pratik@gmail.com"},


        };
        public IActionResult Index()
        {
            return View(students);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.Id = students.Max(s => s.Id) + 1;
            students.Add(student);
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var existing = students.FirstOrDefault(s => s.Id == student.Id);

            if(existing!=null)
            {
                existing.Name = student.Name;
                existing.Age = student.Age;
                existing.Email = student.Email;

            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return View(student);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if(student!=null)
            {
                students.Remove(student);
            }
            
            return RedirectToAction("Index");

        }

      


    }
}
