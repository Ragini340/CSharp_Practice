namespace CSharp_Practice.Threads.MultiThreading
{
    public class ThreadInstanceUsingLambdaExpression
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");

            Thread thread1 = new Thread(() =>
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Method1: " + i);
                }
            });

            Thread thread2 = new Thread(() =>
            {
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine("Method2: " + i);
                }
            });

            thread1.Start();
            thread2.Start();
            Console.WriteLine("Main thread ended");
        }

    }
}