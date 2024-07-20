using WebAppLab5.Interfaces;
using WebAppLab5.Models;

namespace WebAppLab5.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        List<DepartmentModel> departmentList = new List<DepartmentModel>();
        //List<EmployeeModel> empWithDepList = new List<EmployeeModel>();

        public List<DepartmentModel> GetDepartments()
        {

            return departmentList;
        }

        public DepartmentModel GetDepartmentById(int id)
        {
            return departmentList.FirstOrDefault(d => d.DepId == id);
        }

        public void AddDepartment(DepartmentModel department)
        {
            departmentList.Add(department);
        }

        public void UpdateDepartment(DepartmentModel department)
        {
            var existingdepartment = departmentList.FirstOrDefault(d => d.DepId == department.DepId);
            if (existingdepartment != null)
            {
                existingdepartment.Name = department.Name;
                existingdepartment.Description = department.Description;
                // Update other properties as needed
            }
        }

        public void DeleteDepartment(int id)
        {
            var department = departmentList.FirstOrDefault(d => d.DepId == id);
            if (department != null)
            {
                departmentList.Remove(department);
            }
        }
        /*
        public DepartmentModel GetSingleDepartment(int id)
        {
            CreateDepartment();
            DepartmentModel ind = new DepartmentModel();
            ind = departmentList.Where(x => x.DepId == id).FirstOrDefault();
            return ind;
        }

        public void CreateEmployeesWithDept()
        {
            empWithDepList.Add(new EmployeeModel { EmpId = 1, Name = "employee1", Email = "employee1@gmail.com", DepId = 100 });
            empWithDepList.Add(new EmployeeModel { EmpId = 2, Name = "employee2", Email = "employee2@gmail.com", DepId = 100 });
            empWithDepList.Add(new EmployeeModel { EmpId = 3, Name = "employee3", Email = "employee3@gmail.com", DepId = 101 });
        }

        public List<EmployeeModel> GetDepEmployees(int id)
        {
            CreateEmployeesWithDept();
            //List<EmployeeModel> e = new();
            List<EmployeeModel> e = empWithDepList.Where(x => x.DepId == id).ToList();
            return e;
        }
        */

    }
}
