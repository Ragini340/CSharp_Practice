using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers
{
    public class MultipleIndexers_POC
    {
        private List<CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee> employees = new List<CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee>();

        public MultipleIndexers_POC()
        {
            employees.Add(new CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee { EmployeeId = 1, DepartmentId = 11, Name = "A", Gender = "F", Salary = 100 });
            employees.Add(new CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee { EmployeeId = 2, DepartmentId = 22, Name = "B", Gender = "M", Salary = 1000 });
            employees.Add(new CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee { EmployeeId = 3, DepartmentId = 33, Name = "C", Gender = "M", Salary = 10000 });
            employees.Add(new CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee { EmployeeId = 4, DepartmentId = 44, Name = "D", Gender = "M", Salary = 100000 });
            employees.Add(new CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee { EmployeeId = 5, DepartmentId = 55, Name = "E", Gender = "F", Salary = 1000000 });
        }

        public string this[int employeeId]
        {
            get
            {
                foreach (CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee e in employees)
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
                foreach (CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee e in employees)
                {
                    if (e.EmployeeId == employeeId)
                    {
                        e.Name = value;
                    }
                }
            }
        }

        /*public string this[int departmentId]
        {
            get
            {
                foreach (CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee e in employees)
                {
                    if (e.DepartmentId == departmentId)
                    {
                        return e.Name;
                    }
                }
                return null;
            }

            set
            {
                foreach (CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee e in employees)
                {
                    if (e.DepartmentId == departmentId)
                    {
                        e.Name = value;
                    }
                }
            }
        }
        */
        public string this[string gender]
        {
            get
            {
                return employees.Count(employee => employee.Gender == gender).ToString();
            }

            set
            {
                foreach (CSharp_Practice.Indexer.Overloading_With_Indexer.Overloading_With_Three_Indexers.Employee e in employees)
                {
                    if (e.Gender == gender)
                    {
                        e.Gender = value;
                    }
                }
            }
        }
    }
}
