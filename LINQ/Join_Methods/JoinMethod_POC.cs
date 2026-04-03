using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.LINQ.Join_Methods
{
    /*Write a C# program using LINQ to join Employees and Departments and display Employee Name with Department Name.*/

    public class JoinMethod_POC
    {
        public static void GetEmployeeDepartments()
        {
            var employees = new List<Employee>
            {
            new Employee { DeptId = 1, Name = "A" },
            new Employee { DeptId = 2, Name = "B" }
            };

            var departments = new List<Department>
            {
            new Department { Id = 1, DeptName = "IT" },
            new Department { Id = 2, DeptName = "HR" }
            };

            var result = employees.Join(
                departments,
                e => e.DeptId,
                d => d.Id,
                (e, d) => new
                {
                    EmployeeName = e.Name,
                    DepartmentName = d.DeptName
                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.EmployeeName} - {item.DepartmentName}");
            }
        }

        public static void Main(string[] args)
        {
            GetEmployeeDepartments();
        }
    }
}