namespace CSharp_Practice.Threads.MultiThreading.Thread_LifeCycle
{
    public class ThreadLifeCycle_POC
    {
        public void Thread1Method()
        {
            for (int x = 1; x < 6; x++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + x);
            }
            Console.WriteLine("Thread1Method completed.");
        }

        public static void Main(string[] args)
        {
            ThreadLifeCycle_POC threadLifeCycle = new ThreadLifeCycle_POC();
            try
            {
                Thread thread1 = new Thread(threadLifeCycle.Thread1Method)
                {
                    Name = "Thread1"
                };
                Console.WriteLine($"Before Start, IsAlive: {thread1.IsAlive}, ThreadState: {thread1.ThreadState}");

                //Running state
                thread1.Start();
                Console.WriteLine($"After Start(), IsAlive: {thread1.IsAlive}, ThreadState: {thread1.ThreadState}");

                //thread1 is in suspended state
                thread1.Suspend();
                Console.WriteLine($"After Suspend(), IsAlive: {thread1.IsAlive}, ThreadState: {thread1.ThreadState}");

                //thread1 is resume to running state
                thread1.Resume();
                Console.WriteLine($"After Resume(), IsAlive: {thread1.IsAlive}, ThreadState: {thread1.ThreadState}");

                //thread1 is in Abort state
                thread1.Abort();
                Console.WriteLine($"After Abort(), IsAlive: {thread1.IsAlive}, ThreadState: {thread1.ThreadState}");

                //Calling the Start Method on a dead thread will result an Exception
                thread1.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
            }
        }

    }
}