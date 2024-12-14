using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.Solid_Principle.Dependency_Injection.All_Types_Of_DependencyInjection.Common;

namespace CSharp_Practice.Solid_Principle.Dependency_Injection.All_Types_Of_DependencyInjection.Property_Injection
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            //Property Dependency Injection
            EmployeeBL employeeBL = new EmployeeBL();
            employeeBL.EmployeeDataObject = new EmployeeDAL();
            List<Employee> employees = employeeBL.GetAllEmployees();

            foreach (Employee emp in employees)
            {
               Console.WriteLine($"ID = {emp.Id}, Name = {emp.Name}, Department = {emp.Department}");
            }
        }
    }
}
