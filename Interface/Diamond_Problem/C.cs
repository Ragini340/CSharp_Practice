using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Interface.Diamond_Problem
{
    public class C : A, B
    {
        public void Check()
        {
            Console.WriteLine("Check method of interface A");
        }

        void B.Check()
        {
            Console.WriteLine("Check method of interface B");
        }

        public void Print()
        {
            Console.WriteLine("Print method of interface B");
        }
    }

    public class Driver
    {
        public static void Main(string[] args)
        {
            C obj = new C();
            obj.Check();
            obj.Print();
            B b = new C();
            b.Check();
        }
    }

}
