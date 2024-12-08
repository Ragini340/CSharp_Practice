using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.MultiThreading
{
    public class ThreadCreation
    {
        public static void Main()
        {
            Thread thread = new Thread(Worker);
            thread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread is doing some work");
                Thread.Sleep(100);
            }
            thread.Join();
            Console.WriteLine("Work done");

        }

        public static void Worker()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Worker thread is doing some work");
                Thread.Sleep(100);
            }
        }
    }
}
