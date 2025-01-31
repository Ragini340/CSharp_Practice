namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_Mutex
{
    public class CheckMutexState
    {
        private Mutex _mutex;
        public CheckMutexState(bool initiallyOwned, string? name)
        {
            _mutex = new Mutex(true, "MyMutex");
        }

        public void CheckAllMutexFeature()
        {
            try
            {
                var mutexObj = Mutex.OpenExisting("MyMutex1");
                Console.WriteLine("Mutex is available with name MyMutex1");
            }
            catch (WaitHandleCannotBeOpenedException ex)
            {
                Console.WriteLine("Mutext is not available with name MyMutex1");
            }

            //TryOpenExisting(string name, out Mutex result):-
            var mutexTryOpenObj = Mutex.TryOpenExisting("MyMutex1", out Mutex? result);
            Console.WriteLine(mutexTryOpenObj);

            var mutexTryOpen = Mutex.TryOpenExisting("MyMutex", out Mutex? ressult1);
            Console.WriteLine(mutexTryOpen);
        }

        ~CheckMutexState()
        {
            _mutex.Dispose();
        }

        public static void Main(string[] args)
        {
            CheckMutexState obj = new CheckMutexState(true, "MyMutex");
            obj.CheckAllMutexFeature();
        }

    }
}