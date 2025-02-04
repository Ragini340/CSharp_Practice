namespace CSharp_Practice.Threads.MultiThreading
{
    public class ThreadStatePOC
    {
        public static void Method1()
        {
            Console.WriteLine("Method1 started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method1: " + i);
            }
            Console.WriteLine("Thread1 state is: " + Thread.CurrentThread.ThreadState);
            Console.WriteLine("Method1 ended using " + Thread.CurrentThread.Name);
        }

        public static void Method2()
        {
            Console.WriteLine("Method2 started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2: " + i);
            }
            Console.WriteLine("Thread2 state is: " + Thread.CurrentThread.ThreadState);
            Console.WriteLine("Method2 ended using " + Thread.CurrentThread.Name);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            Thread thread1 = new Thread(Method1)
            {
                Name = "Thread1"
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