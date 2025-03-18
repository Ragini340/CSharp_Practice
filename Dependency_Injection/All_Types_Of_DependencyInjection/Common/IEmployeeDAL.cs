using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Dependency_Injection.All_Types_Of_DependencyInjection.Common
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
