using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_Mutex
{
    public class OpenExistingMethod_POC
    {
        public static Mutex _mutex;

        public static bool IsSingleInstance()
        {
            try
            {
                // Try to open Existing Mutex.
                //If MyMutex is not opened, then it will throw an exception
                Mutex.OpenExisting("MyMutex");
            }
            catch
            {
                // If exception occurred, there is no such mutex.
                _mutex = new Mutex(true, "MyMutex");
                // Only one instance.
                return true;
            }
            // More than one instance.
            return false;
        }

        public static void Main(string[] args)
        {
            //If IsSingleInstance returns true continue with the Program else Exit the Program
            if (!IsSingleInstance())
            {
                Console.WriteLine("More than one instance"); // Exit program.
            }
            else
            {
                Console.WriteLine("One instance"); // Continue with program.
            }
        }
    }
}