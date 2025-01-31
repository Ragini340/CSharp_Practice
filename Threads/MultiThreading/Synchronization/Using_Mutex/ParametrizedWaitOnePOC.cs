namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_Mutex
{
    public class ParametrizedWaitOnePOC
    {
        private static Mutex mutex = new Mutex();

        public static void MutexWaitOneDemo()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter critical section for processing");
            /*Note: The Mutex Class is inherited from WaitHandle class and the WaitHandle class provides the WaitOne() method which 
              we need to call to lock the resource. A Mutex can only be released from the same thread which obtained it.*/

            if (mutex.WaitOne(1000))
            {
                try
                {
                    Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is processing now");
                    for (int i = 1; i < 6; i++)
                    {
                        Thread.Sleep(1000); //If we don't use Sleep method here then all three threads will complete it's task.
                        Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                    }
                    Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is completed its task");
                }
                finally
                {
                    mutex.ReleaseMutex();
                    Console.WriteLine(Thread.CurrentThread.Name + " has released the mutex");
                }
            }
            else
            {
                Console.WriteLine(Thread.CurrentThread.Name + " will not acquire the mutex");
            }
        }

        public static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Thread thread = new Thread(MutexWaitOneDemo)
                {
                    Name = "Thread " + i
                };
                thread.Start();
            }
        }

        ~ParametrizedWaitOnePOC()
        {
            mutex.Dispose();
        }

    }
}