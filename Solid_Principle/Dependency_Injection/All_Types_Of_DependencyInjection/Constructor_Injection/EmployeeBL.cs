using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.Solid_Principle.Dependency_Injection.All_Types_Of_DependencyInjection.Common;

namespace CSharp_Practice.Solid_Principle.Dependency_Injection.All_Types_Of_DependencyInjection.Constructor_Injection
{
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;

        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.SelectAllEmployees();
        }
    }
}
