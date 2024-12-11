using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction
{
    public class ChildAbstract_Implementor : ChildAbstract
    {
        public override void area()
        {
            Console.WriteLine("Area of ChildAbstract_Implementor");
        }

        public void calculate()
        {
            Console.WriteLine("I am in non-abstract child class");
        }

    }
}
