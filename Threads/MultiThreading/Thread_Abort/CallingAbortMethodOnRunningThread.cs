namespace CSharp_Practice.Threads.MultiThreading.Thread_Abort
{
    public class CallingAbortMethodOnRunningThread
    {
        public void ThreadMethod()
        {
            try
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} has started its execution");
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                }
                Console.WriteLine($"{Thread.CurrentThread.Name} has finished its execution");
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"ThreadAbortException occurred, Message : {ex.Message}");
            }
        }

        public static void Main(string[] args)
        {
            CallingAbortMethodOnRunningThread abortMethodOnRunningThread = new CallingAbortMethodOnRunningThread();
            Thread thread1 = new Thread(abortMethodOnRunningThread.ThreadMethod)
            {
                Name = "Thread1"
            };
            thread1.Start();
            thread1.Abort();
        }

    }
}