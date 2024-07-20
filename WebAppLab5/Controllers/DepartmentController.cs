using Microsoft.AspNetCore.Mvc;
using WebAppLab5.Interfaces;
using WebAppLab5.Models;
using WebAppLab5.Repository;

namespace WebAppLab5.Controllers
{
    public class DepartmentController : Controller
    {

        IDepartmentRepository depRepo { get; set; }

        public DepartmentController(IDepartmentRepository _depRepo)
        {
            this.depRepo = _depRepo;
        }
        public IActionResult Index()
        {
            var departments = depRepo.GetDepartments();
            return View(departments);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentModel department)
        {
            if (ModelState.IsValid)
            {
                depRepo.AddDepartment(department);
                return RedirectToAction("Index");
            }
            // If model state is not valid, redisplay the form with validation errors
            return View(department);
        }

        public ActionResult Edit(int id)
        {
            var department = depRepo.GetDepartmentById(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }


        [HttpPost]
        public ActionResult Edit(DepartmentModel department)
        {
            if (ModelState.IsValid)
            {
                depRepo.UpdateDepartment(department);
                return RedirectToAction("Index");
            }
            return View(department);
        }

        public ActionResult Delete(int id)
        {
            depRepo.DeleteDepartment(id);
            return RedirectToAction("Index");
        }
    }
}
