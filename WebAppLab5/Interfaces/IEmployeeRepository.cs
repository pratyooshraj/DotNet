using WebAppLab5.Models;

namespace WebAppLab5.Interfaces
{
    public interface IEmployeeRepository
    {
        void AddEmployee(EmployeeModel employee);
        void DeleteEmployee(int id);
        List<EmployeeModel> GetAllEmployees();
        EmployeeModel GetEmployeeById(int id);
        void UpdateEmployee(EmployeeModel employee);
    }
}