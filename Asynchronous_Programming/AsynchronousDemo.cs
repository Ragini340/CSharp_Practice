using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace CSharp_Practice.Asynchronous_Programming
{
    public class AsynchronousDemo
    {
        public static void asyncDemo()
        {
            var watch = new Stopwatch();
            watch.Start();
            var task1 = startSchoolAssembly();
            var task2 = teachClass10();
            var task3 = teachClass9();
            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine("Execution time: " + watch.ElapsedMilliseconds);
        }

        private static async Task startSchoolAssembly()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("School started");
            });
        }

        private static async Task teachClass10()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Taught class10");
            });
        }

        private static async Task teachClass9()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Taught class9");
            });
        }

        public static void Main()
        {
            asyncDemo();
        }

    }
}
