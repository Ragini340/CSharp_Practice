namespace CSharp_Practice.Threads.MultiThreading.Thread_Abort
{
    public class ThreadAbortPOC
    {
        public void ThreadMethod()
        {
            for (int x = 1; x < 6; x++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + x);
            }
        }

        public static void Main(string[] args)
        {
            ThreadAbortPOC abortPOC = new ThreadAbortPOC();
            Thread thread1 = new Thread(abortPOC.ThreadMethod)
            {
                Name = "Thread1"
            };
            thread1.Start();
            Console.WriteLine("Aborting thread1...");
            thread1.Abort();
        }

    }
}