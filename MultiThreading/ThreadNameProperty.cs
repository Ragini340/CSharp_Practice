using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharp_Practice.MultiThreading
{
    public class ThreadNameProperty
    {
        public static void Main()
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Main thread";
            //Console.WriteLine("Current executing thread name is: " + thread.Name);
            Console.WriteLine("Current executing thread name is: " + Thread.CurrentThread.Name);
        }

    }
}
