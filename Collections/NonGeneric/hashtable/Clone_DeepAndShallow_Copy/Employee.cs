using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.NonGeneric.hashtable.Clone_DeepCopy
{
    public class Employee 
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "EmployeeId: " + this.EmployeeId + " Name: " + this.Name;
        }
    }
}
