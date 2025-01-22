namespace CSharp_Practice.Threads.MultiThreading
{
    public class ThreadFunctionUsingParameter
    {
        public void Display1(object Max)
        {
            int Number = Convert.ToInt32(Max);
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine("Method1 using normal approach: " + i);
            }
        }

        public void Display2(object Max)
        {
            int Number = Convert.ToInt32(Max);
            Thread thread2 = new Thread(delegate (object? Max)
            {
                for (int i = 1; i <= Number; i++)
                {
                    Console.WriteLine("Method2 using delegate: " + i);
                }
            });
            thread2.Start(20);
        }

        public void Display3(object Max)
        {
            int Number = Convert.ToInt32(Max);
            Thread thread3 = new Thread(Max =>
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Method3 using Lambda: " + i);
                }
            });
            thread3.Start(20);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            ThreadFunctionUsingParameter obj = new ThreadFunctionUsingParameter();
            Thread thread1 = new Thread(obj.Display1);

            //Or, Creating the ParameterizedThreadStart Instance Manually as below:

            /*ParameterizedThreadStart PTS = new ParameterizedThreadStart(obj.Method1);
            Thread thread1 = new Thread(PTS);
            thread1.Start(20);*/

            //In below Start method is invoking the delegate ParameterizedThreadStart:
            thread1.Start(20);
            obj.Display2(10);
            obj.Display3(5);
            Console.WriteLine("Main thread ended");
        }

    }
}