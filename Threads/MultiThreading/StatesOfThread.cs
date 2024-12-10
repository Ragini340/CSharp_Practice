using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Threads.MultiThreading
{
    public class StatesOfThread
    {
        public void Print()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("My thread");
            }
        }
    }

    public class ExOfStatesOfThread
    {
        public static void Main(string[] args)
        {
            StatesOfThread statesOfThread = new StatesOfThread();

            //Threads unstarted state
            Thread th1 = new Thread(new ThreadStart(statesOfThread.Print));
            Console.WriteLine("ThreadState is: {0}", th1.ThreadState);

            /*
            Or we can write as below:
            Thread th1 = new Thread(statesOfThread.Print);
            Console.WriteLine("ThreadState is: {0}", th1.ThreadState);
            */

            //Running state
            th1.Start();
            Console.WriteLine("ThreadState is: {0}", th1.ThreadState);

            /*
            //th1 is in suspended state
            th1.Suspend();   //Not supported since .NET 5
            Console.WriteLine("ThreadState is: {0}", th1.ThreadState);

            //th1 is resumed to running state
            th1.Resume();  //Not supported since .NET 5
            Console.WriteLine("ThreadState: is {0}", th1.ThreadState); 
            */
        }

    }
}
