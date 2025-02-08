namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_AutoResetEvent_ManualResetEvent.AutoResetEvents
{
    public class AutoResetEventWithMultipleWaitOneAndOneSetMethod
    {
        AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        public void Thread1Method()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter into critical section for processing");

            for (int i = 31; i < 41; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
            Console.WriteLine("Set() has been called from Thread1");
            autoResetEvent.Set(); 
            Console.WriteLine("WaitOne() has been called on Thread1");
            autoResetEvent.WaitOne();

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
            Console.WriteLine("WaitOne() has been called on Thread2");
            autoResetEvent.WaitOne();  

            for (int i = 11; i < 21; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
            Console.WriteLine("WaitOne() has been called on Thread2");
            autoResetEvent.WaitOne();  //In thread2 method two times WaitOne() have been called, so to unblock the two Set() are
                                       //required in other thread but we can see only one Set() is called in thread1 method, so it
                                       //will unblock only one WaitOne() and it will print 11 to 20 but other WaitOne() will still
                                       //block and it will not print 21 to 30.

            for (int i = 21; i < 31; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            }
        }

        public static void Main(string[] args)
        {
            AutoResetEventWithMultipleWaitOneAndOneSetMethod autoReset = new AutoResetEventWithMultipleWaitOneAndOneSetMethod();
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