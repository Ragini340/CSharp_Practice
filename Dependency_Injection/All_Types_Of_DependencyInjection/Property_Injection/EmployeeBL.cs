using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.Dependency_Injection.All_Types_Of_DependencyInjection.Common;

namespace CSharp_Practice.Dependency_Injection.All_Types_Of_DependencyInjection.Property_Injection
{
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;

        public IEmployeeDAL EmployeeDataObject
        {
            set
            {
                employeeDAL = value;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.SelectAllEmployees();
        }
    }
}
