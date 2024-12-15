using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Indexer.Indexer_Real_Life_Example
{
    public class Company
    {
        private List<Employee> employees = new List<Employee>();
        public Company()
        {
            employees.Add(new Employee { EmployeeId = 1, Name = "A", Gender = "F", Salary = 100 });
            employees.Add(new Employee { EmployeeId = 2, Name = "B", Gender = "M", Salary = 1000 });
            employees.Add(new Employee { EmployeeId = 3, Name = "C", Gender = "M", Salary = 10000 });
            employees.Add(new Employee { EmployeeId = 4, Name = "D", Gender = "M", Salary = 100000 });
            employees.Add(new Employee { EmployeeId = 5, Name = "E", Gender = "F", Salary = 1000000 });
        }

        public string this[int employeeId]
        {
            get
            {
                foreach (Employee e in employees)
                {
                    if (e.EmployeeId == employeeId)
                    {
                        return e.Name;
                    }
                }
                return null;
            }
            set
            {
                foreach (Employee e in employees)
                {
                    if (e.EmployeeId == employeeId)
                    {
                        e.Name = value;
                    }
                }
            }

        }
    }
}