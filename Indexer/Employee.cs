using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Indexer
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }

        public Employee(int Id, string Name, string Job, double Salary, string Location, string Department, string Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
            this.Location = Location;
            this.Department = Department;
            this.Gender = Gender;
        }

    }
}
