using WebAppLab5.Interfaces;
using WebAppLab5.Models;

namespace WebAppLab5.Repository
{
    //Extract interface by using the alt+enter
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>();

        public List<EmployeeModel> GetAllEmployees()
        {
            return employees;
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.EmpId == id);
        }

        public void AddEmployee(EmployeeModel employee)
        {
            employees.Add(employee);
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            var existingEmployee = employees.FirstOrDefault(e => e.EmpId == employee.EmpId);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Email = employee.Email;
                existingEmployee.Gender = employee.Gender;
                // Update other properties as needed
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.EmpId == id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }
    }
}
