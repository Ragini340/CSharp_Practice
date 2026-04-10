using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.Dependency_Injection.All_Types_Of_DependencyInjection.Common;

namespace CSharp_Practice.LINQ.EmployeeReportApp
{
    /*
     Write a C# program to:
     Create a list of employees with Name and Salary
     Filter employees whose salary is greater than 50,000
     Sort them in descending order of salary
     Select only Name and Salary
     Take top 5 employees
     Display the result in console
    */
    public class EmployeeReport
    {
        // Sample data
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
        {
            new Employee { Name = "John", Salary = 60000 },
            new Employee { Name = "Alice", Salary = 75000 },
            new Employee { Name = "Bob", Salary = 45000 },
            new Employee { Name = "David", Salary = 90000 },
            new Employee { Name = "Sara", Salary = 85000 },
            new Employee { Name = "Mark", Salary = 52000 },
            new Employee { Name = "Tom", Salary = 30000 },
            new Employee { Name = "Emma", Salary = 70000 }
        };
        }

        // LINQ logic
        public static List<EmployeeDto> GetTopEmployees(List<Employee> employees)
        {
            return employees
                .Where(e => e.Salary > 50000)
                .OrderByDescending(e => e.Salary)
                .Select(e => new EmployeeDto
                {
                    Name = e.Name,
                    Salary = e.Salary
                })
                .Take(5)
                .ToList();
        }

        public static void DisplayEmployees(List<EmployeeDto> employees)
        {
            Console.WriteLine("Top Employees (Salary > 50000):\n");

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Name} - {emp.Salary}");
            }
        }

        public static void Main(string[] args)
        {
            var employees = GetEmployees();

            var topEmployees = GetTopEmployees(employees);

            DisplayEmployees(topEmployees);
        }
    }
}