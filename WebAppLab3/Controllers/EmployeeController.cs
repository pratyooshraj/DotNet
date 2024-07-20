using Microsoft.AspNetCore.Mvc;
using WebAppLab3.Models;
using WebAppLab3.Repository;

namespace WebAppLab3.Controllers
{
    public class EmployeeController : Controller
    {
        List<EmployeeModel> emp = new List<EmployeeModel>();

        public IActionResult Index()
        {
            EmployeeRepository empRepo = new();
            emp = empRepo.GetEmployees();
            return View(emp);
        }

        public IActionResult IndividualEmp(int id)
        {
            EmployeeRepository empRepo = new();
            EmployeeModel e = empRepo.GetSingleEmployee(id);
            return View(e);
        }
    }
}
