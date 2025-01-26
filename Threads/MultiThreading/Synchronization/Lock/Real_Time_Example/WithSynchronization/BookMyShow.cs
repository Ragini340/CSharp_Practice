namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Lock.Real_Time_Example.WithSynchronization
{
    public class BookMyShow
    {
        private object lockObject = new object();
        int AvailableTickets = 3;
        static int i = 1;
        static int j = 2;
        static int k = 3;

        public void BookTicket(string name, int wantedtickets)
        {
            lock (lockObject)
            {
                if (wantedtickets <= AvailableTickets)
                {
                    Console.WriteLine(wantedtickets + " booked to " + name);
                    AvailableTickets = AvailableTickets - wantedtickets;
                    Console.WriteLine("Now number of available tickets for: " + Thread.CurrentThread.Name + " are: " + AvailableTickets);
                }
                else
                {
                    Console.WriteLine("No tickets available to book");
                }
            }
        }

        public void TicketBookig()
        {
            string name = Thread.CurrentThread.Name;
            if (name.Equals("Thread1"))
            {
                BookTicket(name, i);
            }
            else if (name.Equals("Thread2"))
            {
                BookTicket(name, j);
            }
            else
            {
                BookTicket(name, k);
            }
        }

    }
}