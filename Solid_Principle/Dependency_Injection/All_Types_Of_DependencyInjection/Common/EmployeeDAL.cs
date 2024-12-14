using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.Dependency_Injection.All_Types_Of_DependencyInjection.Common
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(){Id = 1, Name = "Rag", Department = "IT"},
                new Employee(){Id = 2, Name = "Abc", Department = "R & D"},
                new Employee(){Id = 3, Name = "Pqr", Department = "Dev"}
            };
            return employees;
        }
    }
}
