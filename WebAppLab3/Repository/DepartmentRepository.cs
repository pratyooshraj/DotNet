using WebAppLab3.Models;

namespace WebAppLab3.Repository
{
    public class DepartmentRepository
    {
        List<DepartmentModel> departmentList=new List<DepartmentModel>();
        List<EmployeeModel> empWithDepList = new List<EmployeeModel>();
        public void CreateDepartment()
        {
            departmentList.Add(new DepartmentModel() { DepId = 100, Name = "Computer", Description = "Computer Department" });
            departmentList.Add(new DepartmentModel() { DepId = 101, Name = "Human Resource", Description = "Hiring new employees" });
        }

        public List<DepartmentModel> GetDepartments()
        {
            CreateDepartment();
            return departmentList;
        }

        public DepartmentModel GetSingleDepartment(int id)
        {
            CreateDepartment();
            DepartmentModel ind = new DepartmentModel();
            ind = departmentList.Where(x => x.DepId == id).FirstOrDefault();
            return ind;
        }

        public void CreateEmployeesWithDept()
        {
            empWithDepList.Add(new EmployeeModel { Id = 1, Name = "employee1", Email = "employee1@gmail.com", DepId = 100 });
            empWithDepList.Add(new EmployeeModel { Id = 2, Name = "employee2", Email = "employee2@gmail.com", DepId=100 });
            empWithDepList.Add(new EmployeeModel { Id = 3, Name = "employee3", Email = "employee3@gmail.com", DepId=101 });
        }

        public List<EmployeeModel> GetDepEmployees(int id)
        {
            CreateEmployeesWithDept();
            //List<EmployeeModel> e = new();
            List<EmployeeModel> e = empWithDepList.Where(x => x.DepId == id).ToList();
            return e;
        }
    }
}
