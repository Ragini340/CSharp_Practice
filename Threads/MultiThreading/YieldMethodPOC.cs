namespace CSharp_Practice.Threads.MultiThreading
{
    public class YieldMethodPOC
    {
        public static void Method1()
        {
            Console.WriteLine("Method1 started using " + Thread.CurrentThread.Name);
            for (int i = 100; i < 1000; i++)
            {
                Thread.Sleep(300);
                Thread.Yield();  //This method causes the calling thread to yield execution to another thread that is ready to run
                                 //on the current processor. The operating system selects the thread to yield to. It returns true if
                                 //the operating system switched execution to another thread; otherwise, false.

                Console.WriteLine("Method1: " + i);
            }
            Console.WriteLine("Method1 ended using " + Thread.CurrentThread.Name);
        }

        public static void Method2()
        {
            Console.WriteLine("Method2 started using " + Thread.CurrentThread.Name);
            for (int i = 1; i < 100; i++)
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