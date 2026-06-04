namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_SemaphoreSlim.Wait_Method
{
    public class SemaphoreSlimPOC
    {
        //Only 3 threads can access resource simulteniously
        public SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(3);

        public void SemaphoreSlimFunction()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter into critical section for processing");
            _semaphoreSlim.Wait();
            Console.WriteLine(Thread.CurrentThread.Name + " entered into critical section");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
            Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is completed its task");

            _semaphoreSlim.Release();
            Console.WriteLine(Thread.CurrentThread.Name + " exits from critical section");
        }

        public static void Main(string[] args)
        {
            SemaphoreSlimPOC obj = new SemaphoreSlimPOC();
            for (int i = 1; i <= 5; i++)
            {
                Thread thread = new Thread(obj.SemaphoreSlimFunction)
                {
                    Name = "Thread " + i
                };
                thread.Start();
            }
        }

    }
}