namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_Mutex
{
    public class ParametrizedWaitOnePOC
    {
        private Mutex mutex = new Mutex();

        public void MutexWaitOneDemo()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter critical section for processing");
            /*Note: The Mutex Class is inherited from WaitHandle class and the WaitHandle class provides the WaitOne() method which 
              we need to call to lock the resource. A Mutex can only be released from the same thread which obtained it.*/

            //In below if I use mutex.WaitOne(1000) then within 1000 ms any thread can access and complete its task.
            //And remaining threads will go into else block and will not acquire the lock and neither accesss the resources.
            if (mutex.WaitOne(1800)) //If I use mutex.WaitOne() without passing time then all three threads will acquire the lock on
                                     //the resources and complete its task one by one.
            {
                try
                {
                    Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is processing now");
                    for (int i = 1; i < 6; i++)
                    {
                        Thread.Sleep(800); //If we don't use Sleep method here then all three threads will complete its task.
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
            ParametrizedWaitOnePOC parametrizedWaitOnePOC = new ParametrizedWaitOnePOC();
            for (int i = 1; i <= 3; i++)
            {
                Thread thread = new Thread(parametrizedWaitOnePOC.MutexWaitOneDemo)
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