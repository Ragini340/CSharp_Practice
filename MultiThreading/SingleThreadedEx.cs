using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.MultiThreading
{
    public class SingleThreadedEx
    {
        public static void Method1()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("This is method1:" + i);
            }
        }

        public static void Method2()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("This is method2:" + i);
            }
        }

        public static void Method3()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("This is method3:" + i);
            }
        }

        public static void Main(string[] args)
        {
            Method1();
            Console.WriteLine();
            Method2();
            Console.WriteLine();
            Method3();
            Console.WriteLine();
        }

    }
}
