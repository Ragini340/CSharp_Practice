namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_Mutex
{
    public class MutexClassPOC
    {
        private static Mutex mutex = new Mutex();

        public static void MutexDemo()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter critical section for processing");
            try
            {
                mutex.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is processing now");
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                }

                Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is completed its task");
            }
            finally
            {
                mutex.ReleaseMutex();
                Console.WriteLine(Thread.CurrentThread.Name + " exits from critical section");
            }
        }

        public static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread threadObject = new Thread(MutexDemo)
                {
                    Name = "Thread " + i
                };
                threadObject.Start();
            }
        }

    }
}