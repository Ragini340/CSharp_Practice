namespace CSharp_Practice.Threads.MultiThreading.InterThread_Communication
{
    public class InterthreadCommunicationExWithWaitAndPulse
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
                Monitor.Pulse(lockObject);
            }
        }

        public static void Main(string[] args)
        {
            InterthreadCommunicationExWithWaitAndPulse interthreadCommunication = new InterthreadCommunicationExWithWaitAndPulse();
            Thread thread1 = new Thread(interthreadCommunication.PrintTable)
            {
                Name = "Thread1"
            };
            thread1.Start();
            lock (lockObject)
            {
                Monitor.Wait(lockObject);
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