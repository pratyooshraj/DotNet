using Microsoft.AspNetCore.Mvc;
using WebAppLab3.Models;
using WebAppLab3.Repository;

namespace WebAppLab3.Controllers
{
    public class DepartmentController : Controller
    {
        List<DepartmentModel> dep = new();
        public IActionResult Index()
        {
            DepartmentRepository depRepo = new();
            dep = depRepo.GetDepartments();
            return View(dep);
        }

        public IActionResult depEmployees(int id)
        {
            DepartmentRepository depRepo = new();
            List<EmployeeModel> empList = new();
            empList = depRepo.GetDepEmployees(id);
            return View(empList);
        }
    }
}

