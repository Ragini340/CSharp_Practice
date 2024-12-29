using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Method_Overriding
{
    public class MethodOverridingChild : MethodOverriding
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Child class Display method");
        }
    }
}
