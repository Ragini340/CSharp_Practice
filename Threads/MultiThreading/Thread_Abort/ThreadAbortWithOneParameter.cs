namespace CSharp_Practice.Threads.MultiThreading.Thread_Abort
{
    public class ThreadAbortWithOneParameter
    {
        public void ThreadMethod()
        {
            try
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is starting");

                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                    if ((i % 10) == 0)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + " numbers divisible by 10 in 1 to 100 are: " + i);
                        Thread.Sleep(200);
                    }
                }
                Console.WriteLine($"{Thread.CurrentThread.Name} exiting normally");
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is aborted and the code is {ex.ExceptionState}");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            ThreadAbortWithOneParameter abortWithOneParameter = new ThreadAbortWithOneParameter();
            Thread thread1 = new Thread(abortWithOneParameter.ThreadMethod)
            {
                Name = "Thread1"
            };
            thread1.Start();
            Console.WriteLine("Abort Thread1");
            thread1.Abort(1000);
            Console.WriteLine("Main thread is terminating");
        }

    }
}