using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_Semaphore
{
    public class TryOpenExisting_Method_POC
    {
        public static void Main(string[] args)
        {
            Semaphore sem;

            if (Semaphore.TryOpenExisting("SemaphoreDemoObject", out sem))
            {
                Console.WriteLine("Semaphore exists.");
                Console.WriteLine("Another instance is running.");
            }
            else
            {
                sem = new Semaphore(1, 1, "NewSemaphoreDemoObject");
                Console.WriteLine("New semaphore created.");
            }
        }
    }
}