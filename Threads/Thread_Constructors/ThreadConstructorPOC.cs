using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Threads.Thread_Constructors
{
    public class ThreadConstructorPOC
    {
        // Method without parameter
        public static void Method1()
        {
            Console.WriteLine("Method1 executed");
        }

        // Method with parameter
        public static void Method2(object input)
        {
            Console.WriteLine($"Method2 executed with parameter: {input}");
        }

        public static void Main(string[] args)
        {
            // 1. Thread(ThreadStart start)
            Thread t1 = new Thread(new ThreadStart(Method1));
            t1.Start();
            t1.Join();

            // 2. Thread(ThreadStart start, int maxStackSize)
            Thread t2 = new Thread(new ThreadStart(Method1), 1048576);
            t2.Start();
            t2.Join();

            // 3. Thread(ParameterizedThreadStart start)
            Thread t3 = new Thread(new ParameterizedThreadStart(Method2));
            t3.Start("Thread t3");
            t3.Join();

            // 4. Thread(ParameterizedThreadStart start, int maxStackSize)
            Thread t4 = new Thread(new ParameterizedThreadStart(Method2), 1048576);

            t4.Start("Thread t4");
            t4.Join();

            Console.WriteLine("All threads completed.");
        }
    }
}