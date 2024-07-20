using Microsoft.AspNetCore.Mvc;
using WebAppLab5.Models;
using WebAppLab5.Interfaces;
using WebAppLab5.Repository;

namespace WebAppLab5.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeRepository empRepo { get; set; }

        public EmployeeController(IEmployeeRepository _empRepo)
        {
            this.empRepo = _empRepo;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var employees = empRepo.GetAllEmployees();
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
                empRepo.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            // If model state is not valid, redisplay the form with validation errors
            return View(employee);
        }


        public ActionResult Edit(int id)
        {
            var employee = empRepo.GetEmployeeById(id);
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
                empRepo.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public ActionResult Delete(int id)
        {
            empRepo.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}