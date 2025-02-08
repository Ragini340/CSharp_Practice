namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_AutoResetEvent_ManualResetEvent.AutoResetEvents
{
    public class AutoResetEventWithMainThreadAndOneNewThread
    {
        static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        public void Thread1Method()
        {
            Console.WriteLine("Starting Thread1");
            autoResetEvent.WaitOne();
            Console.WriteLine("Finishing Thread1");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            AutoResetEventWithMainThreadAndOneNewThread obj = new AutoResetEventWithMainThreadAndOneNewThread();
            Thread thread1 = new Thread(obj.Thread1Method)
            {
                Name = "Thread1"
            };
            thread1.Start();

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Main thread: " + " " + i);
            }
            autoResetEvent.Set();
            Console.WriteLine("Main thread ended");
        }

    }
}