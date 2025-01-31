namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_Mutex
{
    /*OpenExisting(string name): This method is used to open the specified named mutex if it already exists. It returns an object 
      that represents the named system mutex. Here, the parameter name specifies the name of the system mutex to open. It will throw
      ArgumentException if the name is an empty string or name is longer than 260 characters. It will throw ArgumentNullException if
      the name is null.*/
    /*In the below example, we use the OpenExisting method of the Mutex Class. If this method throws an exception, the specified
      named Mutex does not exist or is inaccessible.*/
    public class MutexClassOpenExistingMethodPOC
    {
        private static Mutex _mutex;

        public Mutex IsSingleInstance()
        {
            try
            {
              return Mutex.OpenExisting("MyMutex");            
            }
            catch
            {
                _mutex = new Mutex(true, "MyMutex");
                return _mutex;
            }
            return _mutex;
        }

        public static void Main(string[] args)
        {
            MutexClassOpenExistingMethodPOC obj = new MutexClassOpenExistingMethodPOC();
            if (obj.IsSingleInstance != null)
            {
                Console.WriteLine("Mutex name MyMutex is available"); 
            }
            else
            {
                Console.WriteLine("Mutex name MyMutex is not available");
            }
        }

    }
}