using System.Diagnostics;

namespace CSharp_Practice.Synchronous_Programming
{
    public class SynchronousDemo
    {
        public static void Demo()
        {
            var watch = new Stopwatch();
            watch.Start();
            StartSchoolAssembly();
            TeachClass12();
            TeachClass11();
            watch.Stop();
            Console.WriteLine("Execution Time: " + watch.ElapsedMilliseconds);
        }

        private static void StartSchoolAssembly()
        {
           Thread.Sleep(8000);
           Console.WriteLine("School has started");
        }

        private static void TeachClass12()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Taught class 12");
        }

        private static void TeachClass11()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Taught class 11");
        }

        public static void Main()
        {
            Demo();
        }

    }
}
