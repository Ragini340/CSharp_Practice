using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharp_Practice.Synchronous_Programming
{
    public class SynchronousDemo
    {
        public static void demo()
        {
            var watch = new Stopwatch();
            watch.Start();
            startSchoolAssembly();
            teachClass12();
            teachClass11();
            watch.Stop();
            Console.WriteLine("Execution Time: " + watch.ElapsedMilliseconds);
        }

        private static void startSchoolAssembly()
        {
           Thread.Sleep(8000);
           Console.WriteLine("School has started");
        }

        private static void teachClass12()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Taught class 12");
        }

        private static void teachClass11()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Taught class 11");
        }

        public static void Main()
        {
            demo();
        }

    }
}
