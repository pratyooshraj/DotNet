using WebAppLab5.Models;

namespace WebAppLab5.Interfaces
{
    public interface IDepartmentRepository
    {
        void AddDepartment(DepartmentModel department);
        void DeleteDepartment(int id);
        DepartmentModel GetDepartmentById(int id);
        List<DepartmentModel> GetDepartments();
        void UpdateDepartment(DepartmentModel department);
    }
}