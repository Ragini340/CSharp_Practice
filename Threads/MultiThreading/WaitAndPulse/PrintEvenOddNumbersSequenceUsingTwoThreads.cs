namespace CSharp_Practice.Threads.MultiThreading.WaitAndPulse
{
    public class PrintEvenOddNumbersSequenceUsingTwoThreads
    {
        public const int numberLimit = 20;
        private static object _lockMonitor = new object();

        public static void PrintEvenNumbers()
        {
            try
            {
                Monitor.Enter(_lockMonitor);
                for (int i = 0; i <= numberLimit; i = i + 2)
                {
                    Console.Write($"{i} ");
                    Monitor.Pulse(_lockMonitor);
                    bool isLast = false;
                    if (i == numberLimit)
                    {
                        isLast = true;
                    }
                    if (!isLast)
                    {
                        Monitor.Wait(_lockMonitor);
                    }
                }
            }
            finally
            {
                Monitor.Exit(_lockMonitor);
            }
        }

        public static void PrintOddNumbers()
        {
            try
            {
                Monitor.Enter(_lockMonitor);
                for (int i = 1; i <= numberLimit; i = i + 2)
                {
                    Console.Write($"{i} ");
                    Monitor.Pulse(_lockMonitor);
                    bool isLast = false;
                    if (i == numberLimit - 1)
                    {
                        isLast = true;
                    }
                    if (!isLast)
                    {
                        Monitor.Wait(_lockMonitor);
                    }
                }
            }
            finally
            {
                Monitor.Exit(_lockMonitor);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Even Odd sequence is: ");
            Thread evenThread = new Thread(PrintEvenNumbers);
            Thread oddThread = new Thread(PrintOddNumbers);
            evenThread.Start();
            Thread.Sleep(100);
            oddThread.Start();
            oddThread.Join();
            evenThread.Join();
        }

    }
}

/*Algorithm:
First, the Even thread will start to print the number on the console.
Then, the Even thread will signal the Odd thread to be ready to print the number using the Monitor.Pulse() method.
Then, the Event thread will call the Monitor.Wait() method, which will allow the current thread to block and the Odd thread to start execution.
The Odd Thread will also do the same thing.
The Odd thread will start to print the number on the console.
Then, the Odd thread will signal the Even thread to be ready to print the number using the Monitor.Pulse() method.
Then the Odd thread will call the Monitor.Wait() method, which will allow the current thread to block and allow the Even thread to start execution.
The same process is going on.
*/