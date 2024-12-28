using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Method_Overloading
{
    public class MethodOverloadingChild : MethodOverloadingParent
    {
        public void Add(int a)
        {
            Console.WriteLine("I am in add method of child class");
        }

        public override void Subtract(int a)
        {
            Console.WriteLine("Subtract method of child class");
        }
    }
}
