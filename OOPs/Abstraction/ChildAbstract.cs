using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction
{
    public abstract class ChildAbstract : AbstractionPOC
    {
        //It is not throwing error the implement print() abstract method because this class itself is abstract class.
        public void calculate()
        {
            Console.WriteLine("I am child abstract class");
        }
    }
}
