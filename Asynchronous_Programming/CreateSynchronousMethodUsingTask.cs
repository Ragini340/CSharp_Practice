namespace CSharp_Practice.Asynchronous_Programming
{
    public class CreateSynchronousMethodUsingTask
    {
        public static Task TestMethod1()
        {
            Console.WriteLine("TestMethod1 executing, it does not return anything");
            return Task.CompletedTask;
        }

        public static Task<string> TestMethod2()
        {
            string someValue = "";
            someValue = "TestMethod2 returing a string";
            Console.WriteLine("TestMethod2 executing, it returns a string");
            return Task.FromResult(someValue);
        }

        public static Task TestMethod3()
        {
            Console.WriteLine("TestMethod3 executing, it will throw an exception");
            return Task.FromException(new InvalidOperationException());
        }

        public static Task TestMethod4()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.Cancel();
            Console.WriteLine("TestMethod4 executing, it will cancel the Task exception");
            return Task.FromCanceled(cancellationTokenSource.Token);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main method started");
            TestMethod1();
            TestMethod2();
            TestMethod3();
            TestMethod4();
            Console.WriteLine("Main method completed");
            Console.ReadKey();
        }

    }
}