using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Indexer.Indexer_Real_Life_Example
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return "EmployeeId: " + this.EmployeeId + " Name: " + this.Name + " Gender: " + this.Gender + " Salary: " + this.Salary;
        }
    }
}
