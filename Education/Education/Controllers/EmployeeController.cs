using Education.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Education.Controllers
{
    public class EmployeeController : Controller
    {
        readonly List<Employee> obj = new List<Employee>();
        public EmployeeController()
        {
            obj.Add(new Employee { Id = 1, Name = "Rahul", Country = "India", Email = "rahul@gmail.com" });
            obj.Add(new Employee { Id = 2, Name = "Ramu", Country = "India", Email = "ramu1@gmail.com" });
            obj.Add(new Employee { Id = 3, Name = "Ramesh", Country = "India", Email = " ramesh2@gmail.com" });
            obj.Add(new Employee { Id = 4, Name = "Suresh", Country = "US", Email = " suresh2@gmail.com" });
            obj.Add(new Employee { Id = 5, Name = "Dhaniram", Country = "UK", Email = " dhanira12@gmail.com" });
            obj.Add(new Employee { Id = 6, Name = "Rohit", Country = "Pakistan", Email = " rohit919@gmail.com" });
        }

        public IActionResult Index()
        {
            ViewBag.Employess = obj;
            TempData["User"] = "Rahul";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            obj.Add(emp);
            ViewBag.Employess = obj;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            obj.Add(emp);
            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}