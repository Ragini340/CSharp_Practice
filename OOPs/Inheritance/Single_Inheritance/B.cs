using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Inheritance.Single_Inheritance
{
    public class B : A
    {
        //If I am overriding k as below then it will print B class k's value not of A's class and it is hiding inherited member k of class A:
        //public int k = 20;
        public void Method3()
        {
            Console.WriteLine("Method3 of class B");
        }

        public static void Main()
        {
            B b = new B();
            b.Method1();
            b.Method2();
            b.Method3();
            Console.WriteLine("Value of k: " + b.k);
        }
    }
}
