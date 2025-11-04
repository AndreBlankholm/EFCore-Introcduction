using EFCore_Introcduction;
using Microsoft.EntityFrameworkCore;

var context = new CompanyContext();

context.Departments.Add(
new Department
{
    Name = "Human Resources",
    Employees = new List<Employee>
    {
        new Employee
        {
            Name = "Alice Johnson",
            Position = "HR Manager",
            HireDate = new DateTime(2020, 1, 15)
        },
        new Employee
        {
            Name = "Bob Smith",
            Position = "Recruiter",
            HireDate = new DateTime(2021, 6, 10)
        }
    }
});

context.SaveChanges();

var employees = context.Employees.Where(e => e.Department.Name == "Human Resources").ToList();
Console.WriteLine($"Employees in Human Resources Department: {employees.Count}");