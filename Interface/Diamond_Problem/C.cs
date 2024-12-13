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
            Console.WriteLine("Check method");
        }

        public void Print()
        {
            Console.WriteLine("Print method");
        }
    }

    public class Driver
    {
        public static void Main(string[] args)
        {
            C obj = new C();
            obj.Check();
            obj.Print();
        }
    }

}
