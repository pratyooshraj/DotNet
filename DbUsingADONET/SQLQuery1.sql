CREATE TABLE Departments (
    DepartmentId INT PRIMARY KEY IDENTITY,
    DepartmentName VARCHAR(100) NOT NULL
);

CREATE TABLE Employees (
    EmployeeId INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    DepartmentId INT FOREIGN KEY REFERENCES Departments(DepartmentId)
);