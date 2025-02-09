namespace CSharp_Practice.Threads.MultiThreading.InterThread_Communication
{
    public class ExampleWithoutWaitAndPulse
    {
        static object lockObject = new object();
        public void PrintTable()
        {
            lock (lockObject)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " running and printing the table of 4");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("4 x " + i + " = " + (4 * i));
                }
            }
        }

        public static void Main(string[] args)
        {
            ExampleWithoutWaitAndPulse withoutWaitAndPulse = new ExampleWithoutWaitAndPulse();
            Thread thread1 = new Thread(withoutWaitAndPulse.PrintTable)
            {
                Name = "Thread1"
            };
            thread1.Start();
            lock (lockObject)
            {
                Thread th = Thread.CurrentThread;
                th.Name = "Main Thread";
                Console.WriteLine(Thread.CurrentThread.Name + " running and printing the table of 5");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("5 x " + i + " = " + (5 * i));
                }
            }
        }

    }
}