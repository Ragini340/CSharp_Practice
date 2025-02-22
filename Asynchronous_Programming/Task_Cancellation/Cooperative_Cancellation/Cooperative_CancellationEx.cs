using System.Diagnostics;

namespace CSharp_Practice.Asynchronous_Programming.Task_Cancellation.Cooperative_Cancellation
{
    public class Cooperative_CancellationEx
    {
        private static async void TestMethod()
        {
            int count = 10;
            Console.WriteLine("TestMethod Started");

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            Task task1 = Task.Run(() => { /* Task 1 logic */ }, cancellationTokenSource.Token);
            Task task2 = Task.Run(() => { /* Task 2 logic */ }, cancellationTokenSource.Token);

            cancellationTokenSource.CancelAfter(5000);
            try
            {
                await LongRunningTask(count, cancellationTokenSource.Token);
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nTestMethod Completed");
        }

        public static async Task LongRunningTask(int count, CancellationToken token)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("\nLongRunningTask Started");

            for (int i = 1; i <= count; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("LongRunningTask Processing....");
                if (token.IsCancellationRequested)
                {
                    throw new TaskCanceledException();
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"LongRunningTask took {stopwatch.ElapsedMilliseconds / 1000.0} seconds for processing");
        }

        public static void Main(string[] args)
        {
            TestMethod();
            Console.ReadKey();
        }

    }
}