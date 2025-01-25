namespace CSharp_Practice.Threads.MultiThreading
{
    public class ThreadIsAliveProperty
    {
        public static void Method1()
        {
            Console.WriteLine("Method1: Thread1 Started");
            //Making thread to sleep for 2 seconds
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Method1: Thread1 Ended");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Thread thread1 = new Thread(Method1);
            thread1.Start();

            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 Completed its work");
            }

            thread1.Join();  //Wait Till thread1 to complete its execution
            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 Completed its work");
            }
            Console.WriteLine("Main Thread Ended");
        }

    }
}