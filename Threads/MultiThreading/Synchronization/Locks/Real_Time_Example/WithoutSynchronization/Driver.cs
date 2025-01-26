namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Locks.Real_Time_Example.WithoutSynchronization
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            BookMyShow bookMyShow = new BookMyShow();
            Thread thread1 = new Thread(bookMyShow.TicketBookig)
            {
                Name = "Thread1"
            };
            Thread thread2 = new Thread(bookMyShow.TicketBookig)
            {
                Name = "Thread2"
            };
            Thread thread3 = new Thread(bookMyShow.TicketBookig)
            {
                Name = "Thread3"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

    }
}