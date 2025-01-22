namespace CSharp_Practice.Threads.MultiThreading
{
    public class ThreadAbort
    {
        public static void Method1()
        {
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

            thread1.Start();
            thread2.Start();
            Console.WriteLine("Main thread ended");
        }
    }
}