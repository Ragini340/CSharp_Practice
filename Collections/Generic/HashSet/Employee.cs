using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.Generic.HashSet
{
    public class Employee : IEquatable<Employee>
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public bool Equals(Employee other)
        {
            return this.EmployeeId.Equals(other.EmployeeId);
        }

        public override int GetHashCode()
        {
            return this.EmployeeId.GetHashCode();
        }

        public override string ToString()
        {
            return "EmployeeId: " + EmployeeId + " Name: " + Name + " Gender: " + Gender + " Salary: " + Salary;
        }
    }
}