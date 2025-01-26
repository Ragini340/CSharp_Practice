namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Lock.WithSynchronization
{
    public class ThreadSynchronizationEx
    {
        static object lockObject = new object();
        public static void Method1()
        {
            lock (lockObject)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Current thread is: " + Thread.CurrentThread.Name + " => " + i);
                }
            }
        }

        public static void Main(string[] args)
        {
            Thread thread1 = new Thread(Method1)
            {
                Name = "Thread1"
            };
            Thread thread2 = new Thread(Method1)
            {
                Name = "Thread2"
            };
            Thread thread3 = new Thread(Method1)
            {
                Name = "Thread3"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

    }
}