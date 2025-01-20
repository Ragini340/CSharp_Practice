namespace CSharp_Practice.Threads.MultiThreading
{
    public class MultipleForegroundAndOneBackgroundThread
    {
        public static void Method1()
        {
            Console.WriteLine("Method1 Started");
            Thread thread2 = new Thread(Method2)
            {
                IsBackground = true
            };

            thread2.Start();
            for (int i = 100; i < 1000; i++)
            {
                Console.WriteLine("Foreground thread is running " + i);
            }
            Thread.Sleep(3000);
            Console.WriteLine("Foreground thread exited after completing the assigned tasks even though Main thread has already been completed.");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2 Started");
            Console.WriteLine("Is Background thread? " + Thread.CurrentThread.IsBackground);
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Background thread is running " + i);
                Thread.Sleep(100);
            }
            Console.WriteLine("Background thread exited because Main thread finished, so background thread depends on Main thread life. If Main thread quits then background thread also quits.");
            Console.WriteLine("Press any key to Exit.");
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            //A thread has been created here to run Method1 parallely
            Thread thread1 = new Thread(Method1) { };
        
            Console.WriteLine($"Thread1 is a Background thread:  { thread1.IsBackground }");
            thread1.Start();

            //The control will come here and will exit the main thread or main application
            Console.WriteLine("Main Thread Exited");

            //As the Main thread i.e. foreground thread exits the application then automatically, the background thread quits the
            //application
        }
    }
}