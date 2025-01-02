using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.NonGeneric.ArrayLists
{
    public class CloneableEmployee : ICloneable
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public object Clone()
        {
            return (CloneableEmployee)MemberwiseClone();
        }

        public override string ToString()
        {
            return "EmployeeId: " + EmployeeId + " Name: " + Name + " Gender: " + Gender + " Salary: " + Salary;
        }
    }
}
