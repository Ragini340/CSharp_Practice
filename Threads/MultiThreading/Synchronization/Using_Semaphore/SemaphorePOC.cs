namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_Semaphore
{
    public class SemaphorePOC
    {
        /*Semaphore(int initialCount, int maximumCount): It initializes a new instance of the Semaphore class, specifying the 
          initial number of entries and the maximum number of concurrent entries.

          initialCount: The initial number of requests for the semaphore that can be granted concurrently.It throws ArgumentException 
          if initialCount is greater than maximumCount.

          maximumCount: The maximum number of requests for the semaphore that can be granted concurrently. It will throw 
          ArgumentOutOfRangeException if maximumCount is less than 1 or initialCount is less than 0.
         */
        public Semaphore semaphore = new Semaphore(2, 3);

        public void DoSomeTask()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter into critical section for processing");
            try
            {
                semaphore.WaitOne();
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                }
                Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is completed its task");
            }
            finally
            {
                semaphore.Release();
                Console.WriteLine(Thread.CurrentThread.Name + " exits from critical section");
            }
        }

        public static void Main(string[] args)
        {
            SemaphorePOC obj = new SemaphorePOC();
            for (int i = 1; i <= 5; i++)
            {
                Thread thread = new Thread(obj.DoSomeTask)
                {
                    Name = "Thread " + i
                };
                thread.Start();
            }
        }

    }
}