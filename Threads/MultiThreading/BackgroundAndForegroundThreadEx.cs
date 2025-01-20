namespace CSharp_Practice.Threads.MultiThreading
{
    public class BackgroundAndForegroundThreadEx
    {
        public readonly int maxIterations;

        public BackgroundAndForegroundThreadEx(int maxIterations)
        {
            this.maxIterations = maxIterations;
        }

        public void RunLoop()
        {
            for(int i = 0; i < maxIterations; i++)
            {
                Console.WriteLine("{0} count: {1}", Thread.CurrentThread.IsBackground ? "Background Thread" : "Foreground Thread", i);
                Thread.Sleep(250);
            }
            Console.WriteLine("{0} finished counting", Thread.CurrentThread.IsBackground ? "Background Thread" : "Foreground Thread"); 
        }

        public static void Main(string[] args)
        {
            BackgroundAndForegroundThreadEx foregroundTest = new BackgroundAndForegroundThreadEx(5);
            Console.WriteLine("Foreground thread started");
            Thread foregroundThread = new Thread(new ThreadStart(foregroundTest.RunLoop));
            Console.WriteLine("Foreground thread ended");

            BackgroundAndForegroundThreadEx backgroundTest = new BackgroundAndForegroundThreadEx(50);
            Console.WriteLine("Background thread started");
            Thread backgroundThread = new Thread(new ThreadStart(backgroundTest.RunLoop))
            {
                IsBackground = true
            };
            Console.WriteLine("Background thread ended");

            foregroundThread.Start();
            backgroundThread.Start();
            //Thread.Sleep(10000);
            Console.WriteLine("Main thread exited");
        }

    }
}