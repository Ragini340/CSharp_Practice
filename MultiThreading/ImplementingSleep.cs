using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.MultiThreading
{
    public class ImplementingSleep
    {
        public static void Method1()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("This is Method1: " + i);
            }
        }

        public static void Method2()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("This is Method2: " + i);
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation...");
                    Thread.Sleep(10000);
                    Console.WriteLine("Database Operation Completed.");
                }
            }
        }

        public static void Method3()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("This is Method3: " + i);
            }
        }

        public static void Main(string[] args)
        {
            Method1();
            Console.WriteLine();
            Method2();
            Console.WriteLine();
            Method3();
        }

    }
}
