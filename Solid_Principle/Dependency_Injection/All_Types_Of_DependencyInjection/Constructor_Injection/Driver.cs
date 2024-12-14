using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.Solid_Principle.Dependency_Injection.All_Types_Of_DependencyInjection.Common;

namespace CSharp_Practice.Solid_Principle.Dependency_Injection.All_Types_Of_DependencyInjection.Constructor_Injection
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            //Constructor Dependency Injection
            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            List<Employee> employee = employeeBL.GetAllEmployees();

            foreach (Employee emp in employee)
            {
                Console.WriteLine($"ID = {emp.Id}, Name = {emp.Name}, Department = {emp.Department}");
            }
        }
    }
}
