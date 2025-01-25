namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Real_Time_Example.WithSynchronization
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            BookMyShow bookMyShow = new BookMyShow();
            Thread t1 = new Thread(bookMyShow.TicketBookig)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(bookMyShow.TicketBookig)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(bookMyShow.TicketBookig)
            {
                Name = "Thread3"
            };

            t1.Start();
            t2.Start();
            t3.Start();
        }

    }
}