using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Method_Overriding
{
    public class MethodOverriding
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent class show method");
        }

        public virtual void Display()
        {
            Console.WriteLine("Parent class Display method");
        }
    }
}
