namespace CSharp_Practice.Threads.MultiThreading.Type_Safe_ThreadFunction
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            int Max = 20;
            HelperNumber obj = new HelperNumber(Max);
            Thread thread1 = new Thread(new ThreadStart(obj.DisplayNumbers));
            thread1.Start();
            Console.WriteLine("Main thread ended");
        }

    }
}