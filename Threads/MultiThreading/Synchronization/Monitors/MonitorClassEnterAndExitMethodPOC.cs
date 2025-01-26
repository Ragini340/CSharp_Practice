namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Monitors
{
    public class MonitorClassEnterAndExitMethodPOC
    {
        private static object lockPrintNumbers = new object();

        public static void PrintNumbers()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " trying to enter into the critical section");
            try
            {
                Monitor.Enter(lockPrintNumbers);
                Console.WriteLine(Thread.CurrentThread.Name + " entered into the critical section");
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine(i);
                }
            }
            finally
            {
                Monitor.Exit(lockPrintNumbers);
                Console.WriteLine(Thread.CurrentThread.Name + " exits from critical section");
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