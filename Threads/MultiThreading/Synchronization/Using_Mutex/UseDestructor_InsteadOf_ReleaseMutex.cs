namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Using_Mutex
{
    public class UseDestructor_InsteadOf_ReleaseMutex
    {
        private Mutex _mutex;
        public UseDestructor_InsteadOf_ReleaseMutex(bool initiallyOwned, string? name)
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

        ~UseDestructor_InsteadOf_ReleaseMutex()
        {
            _mutex.Dispose();
        }

        public static void Main(string[] args)
        {
            UseDestructor_InsteadOf_ReleaseMutex obj = new UseDestructor_InsteadOf_ReleaseMutex(true, "MyMutex");
            obj.CheckAllMutexFeature();
        }

    }
}