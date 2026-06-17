using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Threads.MultiThreading.Thread_Pool.Performance_Testing.Using_And_Without_Using_ThreadPool
{
    public class PerformanceTestingExample
    {
        public static void MethodWithThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Test);
                thread.Start();
            }
        }

        public static void MethodWithThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
            }
        }

        public static void Test(object obj)
        {
        }

        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                MethodWithThread();
                MethodWithThreadPool();
            }
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Execution using Thread");
            stopwatch.Start();
            MethodWithThread();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThread is : " + stopwatch.ElapsedTicks.ToString());

            stopwatch.Reset();

            Console.WriteLine("Execution using Thread Pool");
            stopwatch.Start();
            MethodWithThreadPool();
            stopwatch.Stop();
            Console.WriteLine("Time consumed by MethodWithThreadPool is : " + stopwatch.ElapsedTicks.ToString());

            Console.Read();
        }
    }
}