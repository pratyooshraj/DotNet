using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebAppLab4.Models;

namespace WebAppLab4.Controllers
{
    public class EmployeeController : Controller
    {

        private List<EmployeeModel> employees = new List<EmployeeModel>();

        [HttpGet]
        public IActionResult Index()
        {
           
            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                // Here you would typically save the new employee to your data store
                // For demonstration purposes, let's assume we just return a success message
                // return Content($"Employeee id={e.EmpId} Name={e.Name} Email={e.Email} gender={e.Gender} added successfully");
                //employee.EmpId = employees.Count + 1;
                employees.Add(employee);
                return RedirectToAction("Index");
            }
            // If model state is not valid, redisplay the form with validation errors
            return View(employee);
        }


        public ActionResult Edit(int id)
        {
            var employee = employees.FirstOrDefault(e => e.EmpId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }


        [HttpPost]
        public ActionResult Edit(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                var existingEmployee = employees.FirstOrDefault(e => e.EmpId == employee.EmpId);
                if (existingEmployee != null)
                {
                    existingEmployee.Name = employee.Name;
                    existingEmployee.Email = employee.Email;
                    existingEmployee.Gender = employee.Gender;
                    // Update other properties as needed
                    return RedirectToAction("Index");
                }
                else
                {
                    return NotFound();
                }
            }
            return View(employee);
        }

        public ActionResult Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.EmpId == id);
            if (employee != null)
            {
                employees.Remove(employee);
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
