using Assignment_3.Models;
using Assignment_3.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Assignment_3.Controllers
{
    public class UserController:Controller
    {
        private static List<User> users = new List<User>();

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                user.Id = users.Count + 1;
                users.Add(user);
                return RedirectToAction("Login");
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email,string password)
        {
            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null) 
            {
                HttpContext.Session.SetString("UserEmail", user.Email);
                return RedirectToAction("Profile");
            }
            ViewBag.Error = "Invalid Credentials";

            return View();
        }
        
        public IActionResult Profile()
        {
            var email = HttpContext.Session.GetString("UserEmail");
            if(email ==null)
            {
                return RedirectToAction("Login");
            }
            var user = users.FirstOrDefault(u => u.Email == email);

            if (user == null)
            {
                return RedirectToAction("Login");
            }


            var vm = new UserViewModel
            {
                Id= user.Id,
                Name = user.Name,
                Email = user.Email
            };
            return View(vm);
        }

        public IActionResult Edit()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if(email ==null)
            {
                return RedirectToAction("Login");

            }
            var user = users.FirstOrDefault(u => u.Email == email);
            var vm = new UserViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Edit(UserViewModel updateUser)
        {

            Console.WriteLine("ID: " + updateUser.Id);

            var user = users.FirstOrDefault(u => u.Id == updateUser.Id);



            if (user != null)
            {
                user.Name = updateUser.Name;
                user.Email = updateUser.Email;
            }
            return RedirectToAction("Profile");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
