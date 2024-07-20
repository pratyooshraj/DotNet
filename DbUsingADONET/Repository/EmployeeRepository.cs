using DbUsingADONET.Interfaces;
using DbUsingADONET.Models;
using System.Data.SqlClient;
using static DbUsingADONET.Repository.EmployeeRepository;   

namespace DbUsingADONET.Repository
{

     public class EmployeeRepository : IEmployeeRepository
        {
            private readonly string _connectionString;

        public EmployeeRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("sqlConnectionString");
        }

        public IEnumerable<Employee> GetAll()
            {
                var employees = new List<Employee>();

                using (var connection = new SqlConnection(_connectionString))
                {
                    var command = new SqlCommand("SELECT * FROM Employees", connection);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee
                            {
                                EmployeeId = (int)reader["EmployeeId"],
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                DepartmentId = (int)reader["DepartmentId"]
                            });
                        }
                    }
                }

                return employees;
            }

            public Employee GetById(int id)
            {
                Employee employee = null;

                using (var connection = new SqlConnection(_connectionString))
                {
                    var command = new SqlCommand("SELECT * FROM Employees WHERE EmployeeId = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee
                            {
                                EmployeeId = (int)reader["EmployeeId"],
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                DepartmentId = (int)reader["DepartmentId"]
                            };
                        }
                    }
                }

                return employee;
            }

            public void Add(Employee employee)
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    var command = new SqlCommand(
                        "INSERT INTO Employees (FirstName, LastName, DepartmentId) VALUES (@FirstName, @LastName, @DepartmentId)",
                        connection);
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            public void Update(Employee employee)
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    var command = new SqlCommand(
                        "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, DepartmentId = @DepartmentId WHERE EmployeeId = @EmployeeId",
                        connection);
                    command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            public void Delete(int id)
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    var command = new SqlCommand("DELETE FROM Employees WHERE EmployeeId = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    
}
