using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DbUsingADONET.Interfaces;
using DbUsingADONET.Models;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly string _connectionString;

    public DepartmentRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("sqlConnectionString");
    }

    public IEnumerable<Department> GetAll()
    {
        var departments = new List<Department>();

        using (var connection = new SqlConnection(_connectionString))
        {
            var command = new SqlCommand("SELECT * FROM Departments", connection);
            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    departments.Add(new Department
                    {
                        DepartmentId = (int)reader["DepartmentId"],
                        DepartmentName = reader["DepartmentName"].ToString()
                    });
                }
            }
        }

        return departments;
    }

    public Department GetById(int id)
    {
        Department department = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            var command = new SqlCommand("SELECT * FROM Departments WHERE DepartmentId = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    department = new Department
                    {
                        DepartmentId = (int)reader["DepartmentId"],
                        DepartmentName = reader["DepartmentName"].ToString()
                    };
                }
            }
        }

        return department;
    }

    public void Add(Department department)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            var command = new SqlCommand(
                "INSERT INTO Departments (DepartmentName) VALUES (@DepartmentName)",
                connection);
            command.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public void Update(Department department)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            var command = new SqlCommand(
                "UPDATE Departments SET DepartmentName = @DepartmentName WHERE DepartmentId = @DepartmentId",
                connection);
            command.Parameters.AddWithValue("@DepartmentId", department.DepartmentId);
            command.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public void Delete(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            var command = new SqlCommand("DELETE FROM Departments WHERE DepartmentId = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}