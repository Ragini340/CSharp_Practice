namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Monitors
{
    public class MonitorClassOverloadedEnterMethodPOC
    {
        private static object lockPrintNumber = new object();
        public static void PrintNumbers()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " trying to enter into the critical section");
            bool IsLockTaken = false; //If we pass true then it will throw Unhandled exception. Unhandled exception.
                                      //Unhandled exception. System.ArgumentException: Argument must be initialized to
                                      //false (Parameter 'lockTaken')
            try
            {
                Console.WriteLine("IsEntered value is? " + Monitor.IsEntered(lockPrintNumber));
                Monitor.Enter(lockPrintNumber, ref IsLockTaken);
                Console.WriteLine("Value of IsLockTaken? " + IsLockTaken);
                Console.WriteLine("IsEntered value is? " + Monitor.IsEntered(lockPrintNumber));

                if (IsLockTaken)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " entered into the critical section");
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                    }
                }
            }
            finally
            {
                if (IsLockTaken)
                {
                    Monitor.Exit(lockPrintNumber);
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