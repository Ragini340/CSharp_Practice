﻿namespace CSharp_Practice.Threads.Single_Thread
{
    public class ImplementingSleepInSingleThread
    {
        public static void Method1()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("This is Method1: " + i);
            }
        }

        public static void Method2()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("This is Method2: " + i);
                if (i == 1)
                {
                    Console.WriteLine("Performing the Database Operation...");
                    Thread.Sleep(10000);
                    Console.WriteLine("Database Operation Completed.");
                }
            }
        }

        public static void Method3()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("This is Method3: " + i);
            }
        }

        public static void Main(string[] args)
        {
            Method1();
            Console.WriteLine();
            Method2();
            Console.WriteLine();
            Method3();
        }

    }
}
