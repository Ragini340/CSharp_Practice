namespace CSharp_Practice.Threads.MultiThreading.Thread_Pool.Without_ThreadPool
{
    public class WithoutThreadPoolEx
    {
        public void MyMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Background: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}, Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            WithoutThreadPoolEx withoutThreadPoolEx = new WithoutThreadPoolEx();
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(withoutThreadPoolEx.MyMethod)
                {
                    Name = "Thread" + i
                };
                thread.Start();
            }
        }

    }
}