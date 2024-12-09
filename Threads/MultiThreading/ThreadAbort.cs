using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Threads.MultiThreading
{
    public class ThreadAbort
    {
        public void Print()
        {
            for (int i = 0; i < 1000; i = i + 2)
            {
                Thread.Sleep(100);
                Console.WriteLine(i);
            }
        }

        public void Print1()
        {
            for (int i = 1; i < 1000; i = i + 2)
            {
                Thread.Sleep(10000);
                Console.WriteLine(i);
            }
        }
    }

    public class DriverClass
    {
        public static void Main(string[] args)
        {
            ThreadAbort threadAbort = new ThreadAbort();
            Thread thread1 = new Thread(new ThreadStart(threadAbort.Print));
            Thread thread2 = new Thread(new ThreadStart(threadAbort.Print1));
            Console.WriteLine("Is thread1 started ?" + thread1.IsAlive);  // thread1 has not started so out should false
            Console.WriteLine("Is thread2 started ?" + thread2.IsAlive);// thread

            thread1.Start();
            Console.WriteLine("Is thread1 started ?" + thread1.IsAlive);
            Console.WriteLine("Is thread2 started ?" + thread2.IsAlive);
            //thread1.Join();  // Here next thread will start after thread1 
            thread2.Start();

            Console.WriteLine("Is thread1 started ?" + thread1.IsAlive);
            Console.WriteLine("Is thread2 started ?" + thread2.IsAlive);

            // Console.WriteLine("Thread is abort");
            //thread.Abort();
            //thread1.Abort();
        }
    }
}
