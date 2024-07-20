using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab2
{

    //Create a class Employee which contains the properties like ID, Name, Address and Salary.
    //Create another class Imain then print all the employees whose salary is greater than 40000 using the concept of Linq Query.
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
    }

     class Emain
    {
        public List<Employee> employees = new List<Employee>();

        // Method to print employees with salary greater than 40000
        public void AddEmployees()
        {
            Employee e1 = new Employee();
            e1.ID = 1;
            e1.Name = "employee1";
            e1.Address = "kathmandu";
            e1.Salary = 40000;
            employees.Add(e1);
            employees.Add(new Employee { ID = 2, Name = "Ram", Address = "Bhaktapur", Salary = 38000 });
            employees.Add(new Employee { ID = 3, Name = "Bob", Address = "Lumbini", Salary = 55000 });
            employees.Add(new Employee { ID = 4, Name = "John", Address = "pokhara", Salary = 45000 });
        }
        
        public void EmployeesSalaryG()
        {
            var filteredEmployees = employees.Where(emp => emp.Salary > 40000);

            if (filteredEmployees.Any())
            {
                Console.WriteLine("Employees with salary greater than 40000:");
                foreach (var employee in filteredEmployees)
                {
                    Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Address: {employee.Address}, Salary: {employee.Salary}");
                }
            }
            else
            {
                Console.WriteLine("No employees found with salary greater than 40000.");
            }
        }
    }
}
