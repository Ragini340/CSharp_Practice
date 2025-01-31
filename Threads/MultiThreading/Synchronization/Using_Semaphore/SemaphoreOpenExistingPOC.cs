namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_Semaphore
{
    /*Semaphore(int initialCount, int maximumCount, string name) : It initializes a new instance of the Semaphore class, specifying 
      the initial number of entries and the maximum number of concurrent entries, and optionally specifying the name of a system 
      semaphore object.

      initialCount: The initial number of requests for the semaphore that can be granted concurrently.It throws ArgumentException 
      if initialCount is greater than maximumCount.

      maximumCount: The maximum number of requests for the semaphore that can be granted concurrently. It will throw 
      ArgumentOutOfRangeException if maximumCount is less than 1 or initialCount is less than 0.

      name: The name of a named system semaphore object.
    */
    public class SemaphoreOpenExistingPOC
    {
        private Semaphore _semaphore;

        public void CheckAllSemaphoreFeature()
        {
            try
            {
                _semaphore = Semaphore.OpenExisting("SemaphoreDemo");
            }
            catch (WaitHandleCannotBeOpenedException ex)
            {
                //If Semaphore not exists, create a semaphore instance.
                //Here, maximum 2 external threads can access the code at the same time.
                _semaphore = new Semaphore(2, 2, "SemaphoreDemo");
            }
        }

        public static void Main(string[] args)
        {
            SemaphoreOpenExistingPOC obj = new SemaphoreOpenExistingPOC();
            if (obj.CheckAllSemaphoreFeature != null)
            {
                Console.WriteLine("Semaphore exists");
            }
            else
            {
                Console.WriteLine("Semaphore does not exist");
            }
        }

    }
}