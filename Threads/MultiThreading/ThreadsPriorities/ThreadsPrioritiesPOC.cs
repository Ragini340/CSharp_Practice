namespace CSharp_Practice.Threads.MultiThreading.ThreadsPriorities
{
    public class ThreadsPrioritiesPOC
    {
        public void ThreadMethod()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
        }

        public static void Main(string[] args)
        {
            ThreadsPrioritiesPOC threadsPrioritiesPOC = new ThreadsPrioritiesPOC();
            Thread thread1 = new Thread(threadsPrioritiesPOC.ThreadMethod)
            {
                Name = "Thread1"
            };
            thread1.Priority = ThreadPriority.Lowest;

            Thread thread2 = new Thread(threadsPrioritiesPOC.ThreadMethod)
            {
                Name = "Thread2"
            };
            thread2.Priority = ThreadPriority.BelowNormal;

            Thread thread3 = new Thread(threadsPrioritiesPOC.ThreadMethod)
            {
                Name = "Thread3"
            };
            thread3.Priority = ThreadPriority.Normal;

            Thread thread4 = new Thread(threadsPrioritiesPOC.ThreadMethod)
            {
                Name = "Thread4"
            };
            thread4.Priority = ThreadPriority.AboveNormal;

            Thread thread5 = new Thread(threadsPrioritiesPOC.ThreadMethod)
            {
                Name = "Thread5"
            };
            thread5.Priority = ThreadPriority.Highest;

            Console.WriteLine($"Thread1 Priority: {thread1.Priority}");
            Console.WriteLine($"Thread2 Priority: {thread2.Priority}");
            Console.WriteLine($"Thread3 Priority: {thread3.Priority}");
            Console.WriteLine($"Thread4 Priority: {thread4.Priority}");
            Console.WriteLine($"Thread5 Priority: {thread5.Priority}");
            
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
        }

    }
}