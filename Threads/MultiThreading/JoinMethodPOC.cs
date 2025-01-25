namespace CSharp_Practice.Threads.MultiThreading
{
    public class JoinMethodPOC
    {
        public static void Method1()
        {
            Console.WriteLine("Method1: Thread1 Started");
            Thread thread2 = new Thread(Method2);
            thread2.Start();
            thread2.Join(); //thread2 blocking thread1 execution
            for (int i = 1; i < 11; i++)
            {
                //Thread.Sleep(1000);
                Console.WriteLine("Method1 is running: " + i);
            }
            Console.WriteLine("Method1: Thread1 Ended");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2: Thread2 Started");
            Thread thread3 = new Thread(Method3);
            thread3.Start();
            thread3.Join(); //thread3 blocking thread2 execution
            for (int i = 11; i < 21; i++)
            {
                //Thread.Sleep(2000);
                Console.WriteLine("Method2 is running: " + i);
            }
            Console.WriteLine("Method2: Thread2 Ended");
        }

        public static void Method3()
        {
            Console.WriteLine("Method3: Thread3 Started");
            for (int i = 21; i < 31; i++)
            {
                //Thread.Sleep(5000);
                Console.WriteLine("Method3 is running: " + i);
            }
            Console.WriteLine("Method3: Thread3 Ended");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            Thread thread1 = new Thread(Method1);
            //Thread thread2 = new Thread(Method2);
            //Thread thread3 = new Thread(Method3);
            thread1.Start(); //thread1 blocking Main thread execution
            //thread2.Start();
            //thread3.Start();
            thread1.Join(); //Blocking Main Thread until thread1 completes its execution
            //thread2.Join(); //Blocking Main Thread until thread2 completes its execution
            //thread3.Join(); //Blocking Main Thread until thread3 completes its execution

            Console.WriteLine("Main Thread Ended");
        }

    }
}