using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Inheritance.Diamond_Problem_Multiple_Inheritance
{
    public class A
    {
        public void Check()
        {
            Console.WriteLine("I am in class A");
        }
    }

    public class B : A
    {
        public void Check()
        {
            Console.WriteLine("I am in class B");
        }
    }

    public class C : A
    {
        public void Check()
        {
            Console.WriteLine("I am in class C");
        }
    }

    /*public class D : B, C  //Class D cannot have multiple base classes B and C
    {
    }
    */

    public class E : C
    {
    }

    public class Driver
    {
        public static void Main(string[] args)
        {
            E e = new E();
            e.Check(); //It will print Check() of class C

            /*
            D obj = new D();
            obj.Check(); */ //Compiler will get confuse which Check() should be called from B or C class
        }
    }
   
}