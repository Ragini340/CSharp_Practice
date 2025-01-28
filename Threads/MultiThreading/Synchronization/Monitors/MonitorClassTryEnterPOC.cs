namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Monitors
{
    public class MonitorClassTryEnterPOC
    {
        private static object lockPrintNumbers = new object();
        public static void PrintNumbers()
        {
            TimeSpan timeout = TimeSpan.FromMilliseconds(1000);
            bool lockTaken = false;

            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + " trying to enter into the critical section");
                Monitor.TryEnter(lockPrintNumbers, timeout, ref lockTaken);
                if (lockTaken)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " entered into the critical section");
                    for (int i = 1; i < 11; i++)
                    {
                        Thread.Sleep(100);  
                        Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                    }
                }
                else
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " lock was not acquired");
                }
            }
            finally
            {
                if (lockTaken)
                {
                    Monitor.Exit(lockPrintNumbers);
                    Console.WriteLine(Thread.CurrentThread.Name + " exits from critical section");
                }
            }
        }

        public static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                threads[i] = new Thread(PrintNumbers)
                {
                    Name = "Child Thread " + i
                };
            }
            foreach (Thread th in threads)
            {
                th.Start();
            }
        }

    }
}