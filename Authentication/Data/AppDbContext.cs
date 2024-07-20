using Authentication.Models;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<EmployeeModel> EmployeeTable { get; set; }
        public DbSet<DepartmentModel> DepartmentTable { get; set; }
    }
}
