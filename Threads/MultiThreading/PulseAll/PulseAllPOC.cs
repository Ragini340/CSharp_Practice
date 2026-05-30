using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Threads.MultiThreading.PulseAll
{
    public class PulseAllPOC
    {
        private static readonly object locker = new object();
        private static bool requestsAvailable = false;

        public static void Worker()
        {
            lock (locker)
            {
                while (!requestsAvailable)
                {
                    Monitor.Wait(locker);
                }

                Console.WriteLine($"Worker {Thread.CurrentThread.ManagedThreadId} processing requests");
            }
        }

        public static void Main(string[] args)
        {
            // Start multiple workers
            for (int i = 0; i < 3; i++)
            {
                new Thread(Worker).Start();
            }

            Thread.Sleep(2000);

            lock (locker)
            {
                requestsAvailable = true;
                Monitor.PulseAll(locker);
            }
        }
    }
}