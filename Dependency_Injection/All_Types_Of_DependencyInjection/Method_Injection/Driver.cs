using CSharp_Practice.Dependency_Injection.All_Types_Of_DependencyInjection.Common;

namespace CSharp_Practice.Dependency_Injection.All_Types_Of_DependencyInjection.Method_Injection
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