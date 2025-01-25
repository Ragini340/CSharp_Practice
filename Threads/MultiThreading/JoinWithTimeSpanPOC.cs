namespace CSharp_Practice.Threads.MultiThreading
{
    public class JoinWithTimeSpanPOC
    {
        public static void Method1()
        {
            Console.WriteLine("Method1: Thread1 Started");
            for (int i = 1; i < 6; i++)
            {
                // Thread.Sleep(1000);
                Console.WriteLine("Method1 is running: " + i);
            }

            Console.WriteLine("Method1: Thread1 Ended");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2: Thread2 Started");
            for (int i = 6; i < 11; i++)
            {
                Console.WriteLine("Method2 is running: " + i);
            }
            Console.WriteLine("Method2: Thread2 Ended");
        }

        public static void Method3()
        {
            Console.WriteLine("Method3: Thread3 Started");
            for (int i = 11; i < 21; i++)
            {
                Console.WriteLine("Method3 is running: " + i);
            }
            Console.WriteLine("Method3: Thread3 Ended");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            Thread thread3 = new Thread(Method3);
            thread1.Start();
            thread2.Start();
            thread3.Start();

            if (thread2.Join(TimeSpan.FromSeconds(3)))
            {
                Console.WriteLine("Thread 2 Execution Completed in 3 second");
            }
            else
            {
                Console.WriteLine("Thread 2 Execution Not Completed in 3 second");
            }
            //Now, Main Thread will block for 3 seconds and wait thread3 to complete its execution
            if (thread3.Join(3000))
            {
                Console.WriteLine("Thread 3 Execution Completed in 3 second");
            }
            else
            {
                Console.WriteLine("Thread 3 Execution Not Completed in 3 second");
            }
            Console.WriteLine("Main Thread Ended");
        }

    }
}