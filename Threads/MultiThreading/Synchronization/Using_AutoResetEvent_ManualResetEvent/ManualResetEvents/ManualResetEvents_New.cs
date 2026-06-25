using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_AutoResetEvent_ManualResetEvent.ManualResetEvents
{
    public class ManualResetEvents_New
    {
        ManualResetEvent manualResetEvent = new ManualResetEvent(false);

        public void Thread1Method()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter into critical section for processing");
            for (int i = 31; i < 41; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
            manualResetEvent.WaitOne();
            manualResetEvent.Set();

            for (int i = 41; i < 51; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
            Console.WriteLine("Set() has been called from Thread1");
        }

        public void Thread2Method()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter into critical section for processing");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
            Console.WriteLine("WaitOne() has been called on Thread2");
            manualResetEvent.WaitOne();

            for (int i = 11; i < 21; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
            manualResetEvent.Set();
        }

        public static void Main(string[] args)
        {
            ManualResetEvents_New autoReset = new ManualResetEvents_New();
            Thread thread1 = new Thread(autoReset.Thread1Method)
            {
                Name = "Thread1"
            };
            Thread thread2 = new Thread(autoReset.Thread2Method)
            {
                Name = "Thread2"
            };
            thread2.Start();
            Thread.Sleep(1000);
            thread1.Start();
        }

    }
}