using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class AppDBContext : DbContext    //Inherits from DBContext of EFCore
    {
        public AppDBContext(DbContextOptions options) : base(options)   //alt+enter on AppDBContext to create constructor with options to send data to base class
        {

        }

        public DbSet<EmployeeModel> EmployeeTable { get; set; }         //Create a table namedd as EmployeeTable   
    }
}
