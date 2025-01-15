namespace CSharp_Practice.Threads
{
    public class ThreadNameProperty
    {
        public static void Main()
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Main thread";
            Console.WriteLine("Current executing thread name is: " + thread.Name);
            Console.WriteLine("Current executing thread name is: " + Thread.CurrentThread.Name);
        }

    }
}
