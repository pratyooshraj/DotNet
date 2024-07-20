using WebAppLab3.Models;

namespace WebAppLab3.Repository
{
    public class EmployeeRepository
    {
        List<EmployeeModel> employeesList = new List<EmployeeModel>();

        public void CreateEmployees()
        {
            EmployeeModel e = new EmployeeModel();
            e.Id = 1;
            e.Name = "employee1";
            e.Email = "employee1@gmail.com";


            employeesList.Add(e);
            employeesList.Add(new EmployeeModel { Id = 2, Name = "employee2", Email = "employee2@gmail.com" });
            employeesList.Add(new EmployeeModel { Id = 3, Name = "employee3", Email = "employee3@gmail.com" });
        }

        public List<EmployeeModel> GetEmployees()
        {
            CreateEmployees();
            return employeesList;
        }

        public EmployeeModel GetSingleEmployee(int id)
        {
            CreateEmployees();
            EmployeeModel ind = new EmployeeModel();
            ind = employeesList.Where(x => x.Id == id).FirstOrDefault();
            return ind;
        }
    }
}
