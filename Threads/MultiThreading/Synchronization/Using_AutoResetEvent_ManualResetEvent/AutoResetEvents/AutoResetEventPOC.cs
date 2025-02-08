namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_AutoResetEvent_ManualResetEvent.AutoResetEvents
{
    public class AutoResetEventPOC
    {
        AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        public void Thread1Method()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter into critical section for processing");
            for (int i = 30; i < 41; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
            autoResetEvent.Set();  //It will print 30 to 40 and then it will give signal to Thread2 to resume its work.
            Console.WriteLine("Thread1 is going on halt by calling WaitOne()");
            autoResetEvent.WaitOne();  //Thread1 is going to keep on halt until other thread will signal to resume the
                                       //execution by calling the Set() of AutoResetEvent class, so here 41 to 50 will
                                       //print after getting signal to resume the work by Thread2.
            Console.WriteLine("Got signal from Thread2 to resume the work, so I am printing 41 to 50");
            for (int i = 41; i < 51; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
        }

        public void Thread2Method()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter into critical section for processing");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
            Console.WriteLine("Thread2 is going on halt by calling WaitOne()");
            autoResetEvent.WaitOne();  //It will go on halt and it will not print until other thread will signal it to
                                       //resume the execution by calling Set() of AutoResetEvent. Here we are calling
                                       //Set() from Thread1 then it will resume printing from 11 to 20.
            Console.WriteLine("Got signal from Thread1 to resume the work, so I am printing 11 to 20");
            Console.WriteLine("Processing now loop from 11 to 20");
            for (int i = 11; i < 21; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
            autoResetEvent.Set();
        }

        public static void Main(string[] args)
        {
            AutoResetEventPOC autoReset = new AutoResetEventPOC();
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