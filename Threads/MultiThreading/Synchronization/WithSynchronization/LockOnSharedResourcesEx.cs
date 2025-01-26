namespace CSharp_Practice.Threads.MultiThreading.Synchronization.WithSynchronization
{
    public class LockOnSharedResourcesEx
    {
        static int Count = 0;
        private static object LockCount = new object();
        public static void IncrementCount()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                lock (LockCount)
                {
                    Count = Count + 1;
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            Thread thread1 = new Thread(IncrementCount);
            Thread thread2 = new Thread(IncrementCount);
            Thread thread3 = new Thread(IncrementCount);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread1.Join();
            thread2.Join();
            thread3.Join();
            Console.WriteLine("Count is: " + Count);
            Console.WriteLine("Main thread ended");
        }

    }
}