namespace CSharp_Practice.Threads.MultiThreading
{
    public class ThreadPropertiesAndMethods
    {
        public static void Method1()
        {
            /*CurrentThread: This property is used to get the currently running thread. It returns a Thread that is the
              representation of the currently running thread.*/
            Console.WriteLine("The representation of the currently running thread is: " + Thread.CurrentThread); //It will print
                                                                                                                 //System.Threading.Thread

            /*IsAlive: This property is used to get a value indicating the execution status of the current thread. It returns true 
              if this thread has been started and has not terminated normally or aborted; otherwise, false.*/
            Console.WriteLine("Thread IsAlive property: " + Thread.CurrentThread.IsAlive);

            /*IsBackground: This property is used to get or set a value indicating whether or not a thread is a background thread.
              It returns true if this thread is or is to become a background thread; otherwise, false.
             */
            Console.WriteLine("IsBackground thread? " + Thread.CurrentThread.IsBackground);

            /*ManagedThreadId: This property is used to get a unique identifier for the current managed thread. It returns an
             integer that represents a unique identifier for this managed thread.*/
            Console.WriteLine("Current thread Id is: " + Thread.CurrentThread.ManagedThreadId);

            /*Priority: This property is used to get or set a value indicating the scheduling priority of a thread. It returns one of
              the System.Threading.ThreadPriority values. The default value is System.Threading.ThreadPriority.Normal.*/
            Console.WriteLine("Priority of Thread1 is: " + Thread.CurrentThread.Priority);

            /*IsThreadPoolThread: This property is used to get a value indicating whether or not a thread belongs to the managed 
              thread pool. It returns true if this thread belongs to the managed thread pool; otherwise, false.*/
            Console.WriteLine("Does Thread1 blong to threadpool? " + Thread.CurrentThread.IsThreadPoolThread);

            /*Name: This property is used to get or set the name of the thread. It returns a string containing the name of the 
            thread, or null if no name was set.*/
            Console.WriteLine("Method1 started using " + Thread.CurrentThread.Name);

            for (int i = 100; i < 1000; i++)
            {
                Console.WriteLine("Method1: " + i);
                try
                {
                    /*Abort(): This method is used to terminate the thread. Raises a ThreadAbortException in the thread on which it 
                      is invoked, to begin the process of terminating the thread. Calling this method usually terminates the thread.*/

                    Thread.CurrentThread.Abort();  //It will print only 1 record from Thread1 and then it will abort.
                }
                catch (Exception e)
                {
                    Console.WriteLine("Handling ThreadAbortException.");
                }
            }

            Console.WriteLine("Method1 ended using " + Thread.CurrentThread.Name);
        }

        public static void Method2()
        {
            Console.WriteLine("Priority of Thread2 is: " + Thread.CurrentThread.Priority);
            Console.WriteLine("Method2 started using " + Thread.CurrentThread.Name);
            for (int i = 1; i < 999; i++)
            {
                Console.WriteLine("Method2: " + i);
            }
            Console.WriteLine("Method2 ended using " + Thread.CurrentThread.Name);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            Thread thread1 = new Thread(Method1)
            {
                Name = "Thread1",
            };
            Thread thread2 = new Thread(Method2)
            {
                Name = "Thread2",
            };

            //Setting Thread1 priority to highest
            thread1.Priority = ThreadPriority.Highest;

            Console.WriteLine("Main thread priority is: " + Thread.CurrentThread.Priority); //By default main thread has normal
                                                                                            //priority and it's value is 2

            /*Start(): This method causes the operating system to change the state of the current instance to System.Threading.
              ThreadState.Running.*/
            thread1.Start();
            thread2.Start();

            /*Join(): This method is used to block the calling thread until the thread represented by this instance terminates*/
            thread1.Join();

            Console.WriteLine("Main thread ended");
        }

    }
}