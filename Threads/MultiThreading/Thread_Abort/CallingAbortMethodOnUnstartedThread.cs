namespace CSharp_Practice.Threads.MultiThreading.Thread_Abort
{
    public class CallingAbortMethodOnUnstartedThread
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
            CallingAbortMethodOnUnstartedThread abortMethodOnUnstartedThread = new CallingAbortMethodOnUnstartedThread();
            try
            {
                Thread thread1 = new Thread(abortMethodOnUnstartedThread.ThreadMethod)
                {
                    Name = "Thread1"
                };
                thread1.Abort();
                thread1.Start();
                Console.WriteLine("Main thread has terminated");
            }
            catch (ThreadStartException ex)
            {
                Console.WriteLine($"ThreadStartException occurred, Message : {ex.Message}");
            }
        }

    }
}