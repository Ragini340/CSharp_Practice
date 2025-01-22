namespace CSharp_Practice.Threads.MultiThreading
{
    public class ThreadInstanceUsingAnonymousMethod
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");

            Thread thread1 = new Thread(delegate ()
            {
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine("Method1: " + i);
                }
            });

            Thread thread2 = new Thread(delegate ()
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Method2: " + i);
                }
            });

            thread1.Start(); //Here, Start method is invoking the delegate ThreadStart
            thread2.Start();
            Console.WriteLine("Main thread ended");
        }

    }
}