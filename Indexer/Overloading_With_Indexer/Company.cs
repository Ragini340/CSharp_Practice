using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.Indexer.Indexer_Real_Life_Example;
using CSharp_Practice.Interface.Diamond_Problem;
using CSharp_Practice.OOPs.Inheritance.Diamond_Problem_Multiple_Inheritance;

namespace CSharp_Practice.Indexer.Overloading_With_Indexer
{
    public class Company
    {
        private List<CSharp_Practice.Indexer.Indexer_Real_Life_Example.Employee> employees = new List<CSharp_Practice.Indexer.Indexer_Real_Life_Example.Employee>();
        
        public Company()
        {
            employees.Add(new CSharp_Practice.Indexer.Indexer_Real_Life_Example.Employee { EmployeeId = 1, Name = "A", Gender = "F", Salary = 100 });
            employees.Add(new CSharp_Practice.Indexer.Indexer_Real_Life_Example.Employee { EmployeeId = 2, Name = "B", Gender = "M", Salary = 1000 });
            employees.Add(new CSharp_Practice.Indexer.Indexer_Real_Life_Example.Employee { EmployeeId = 3, Name = "C", Gender = "M", Salary = 10000 });
            employees.Add(new CSharp_Practice.Indexer.Indexer_Real_Life_Example.Employee { EmployeeId = 4, Name = "D", Gender = "M", Salary = 100000 });
            employees.Add(new CSharp_Practice.Indexer.Indexer_Real_Life_Example.Employee { EmployeeId = 5, Name = "E", Gender = "F", Salary = 1000000 });
        }

        public string this[int employeeId]
        {
            get
            {
                foreach (CSharp_Practice.Indexer.Indexer_Real_Life_Example.Employee e in employees)
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
                foreach (CSharp_Practice.Indexer.Indexer_Real_Life_Example.Employee e in employees)
                {
                    if (e.EmployeeId == employeeId)
                    {
                        e.Name = value;
                    }
                }
            }
        }

        public string this[string gender]
        {
            get
            {
                return employees.Count(employee => employee.Gender == gender).ToString();
            }

            set
            {
                foreach (CSharp_Practice.Indexer.Indexer_Real_Life_Example.Employee e in employees)
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