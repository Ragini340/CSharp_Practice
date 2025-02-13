using System.Diagnostics;

namespace CSharp_Practice.Asynchronous_Programming
{
    public class AsynchronousDemo
    {
        public static void AsyncDemo()
        {
            var watch = new Stopwatch();
            watch.Start();
            var task1 = StartSchoolAssembly();
            var task2 = TeachClass10();
            var task3 = TeachClass9();
            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine("Execution time: " + watch.ElapsedMilliseconds);
        }

        private static async Task StartSchoolAssembly()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("School started");
            });
        }

        private static async Task TeachClass10()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Taught class10");
            });
        }

        private static async Task TeachClass9()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Taught class9");
            });
        }

        public static void Main()
        {
            AsyncDemo();
        }

    }
}
