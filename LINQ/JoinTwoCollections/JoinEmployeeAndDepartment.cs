using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.LINQ.JoinTwoCollections
{
    /*Join employee and department collections using LINQ.*/
    public class JoinEmployeeAndDepartment
    {
        public static void DisplayEmployeeDepartments()
        {
            var employees = GetEmployees();
            var departments = GetDepartments();

            var result = employees.Join(
                departments,
                emp => emp.DeptId,
                dept => dept.Id,
                (emp, dept) => new
                {
                    EmployeeName = emp.Name,
                    DepartmentName = dept.DeptName
                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.EmployeeName} - {item.DepartmentName}");
            }
        }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
        {
            new Employee { Name = "John", DeptId = 1 },
            new Employee { Name = "David", DeptId = 2 }
        };
        }

        public static List<Department> GetDepartments()
        {
            return new List<Department>
        {
            new Department { Id = 1, DeptName = "HR" },
            new Department { Id = 2, DeptName = "IT" }
        };
        }

        public static void Main(string[] args)
        {
            DisplayEmployeeDepartments();
        }

    }
}