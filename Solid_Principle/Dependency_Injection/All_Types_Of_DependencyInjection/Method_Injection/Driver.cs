using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.Solid_Principle.Dependency_Injection.All_Types_Of_DependencyInjection.Common;

namespace CSharp_Practice.Solid_Principle.Dependency_Injection.All_Types_Of_DependencyInjection.Method_Injection
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            List<Employee> employees = employeeBL.GetAllEmployees(new EmployeeDAL());

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"ID = {emp.Id}, Name = {emp.Name}, Department = {emp.Department}");
            }
        }
    }
}