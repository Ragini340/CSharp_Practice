using System.Diagnostics;

namespace CSharp_Practice.Asynchronous_Programming.Task_Cancellation.UserInitiated_Cancellation
{
    public class UserInitiatedCancellation_Ex
    {
        private static async void TestMethod()
        {
            int count = 10;
            Console.WriteLine("TestMethod Started");

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    if (cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        return;
                    }
                }
            }, cancellationTokenSource.Token);

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