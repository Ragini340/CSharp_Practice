using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Polymorphism
{
    public class PolymorphismPOC
    {
        public int Add(int a, int b)
        {
            return a + b;

        }
        public int Add(int a, int b, int c)
        {
            return Add(a + b, a + c);
        }

        public static void Main(string[] args) 
        {
            PolymorphismPOC polymorphismPOC = new PolymorphismPOC();
            int add1 = polymorphismPOC.Add(1, 2);
            int add2 = polymorphismPOC.Add(8, 2, 3);
            Console.WriteLine(add1);
            Console.WriteLine(add2);
        }
    }
}
