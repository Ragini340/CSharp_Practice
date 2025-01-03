using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.NonGeneric.hashtable.Clone_DeepAndShallow_Copy
{
    public class CloneableEmployee : ICloneable
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "EmployeeId: " + EmployeeId + " Name: " + Name;
        }
    }
}
