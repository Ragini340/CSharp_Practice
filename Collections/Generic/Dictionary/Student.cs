using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.Generic.Dictionary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }

        public override string ToString()
        {
            return "Id: " + this.Id + " Name: " + this.Name + " Branch: " + this.Branch;
        }
    }
}
