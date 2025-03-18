using CSharp_Practice.Dependency_Injection.All_Types_Of_DependencyInjection.Common;

namespace CSharp_Practice.Dependency_Injection.All_Types_Of_DependencyInjection.Constructor_Injection
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