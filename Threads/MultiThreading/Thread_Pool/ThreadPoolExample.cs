namespace CSharp_Practice.Threads.MultiThreading.Thread_Pool
{
    //https://stackoverflow.com/questions/16705313/why-threadpool-thread-doesnt-print-anything-to-console-unless-main-thread-print
    public class ThreadPoolExample
    {
        public void MyMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Background: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}, Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }

        public static void Main(string[] args)
        {
            ThreadPoolExample threadPoolExample = new ThreadPoolExample();
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(threadPoolExample.MyMethod));
            }
            Console.Read();
        }

    }
}