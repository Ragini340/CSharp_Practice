using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Method_Overloading
{
    public class MethodOverloadingParent
    {
        public void Add(int a)
        {
            Console.WriteLine("I am in add method of parent class");
        }

        public virtual void Subtract(int a)
        {
            Console.WriteLine("Subtract method of parent class");
        }
    }
}
