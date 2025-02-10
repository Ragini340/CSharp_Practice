namespace CSharp_Practice.Asynchronous_Programming
{
    public class WithoutAsyncAndAwait
    {
        public void Print()
        {
            Console.WriteLine("Print method started......");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n");
            Console.WriteLine("Print method end");
        }

        public static void Main(string[] args)
        {
            WithoutAsyncAndAwait withoutAsyncAndAwait = new WithoutAsyncAndAwait();
            Console.WriteLine("Main method started......");
            withoutAsyncAndAwait.Print();
            Console.WriteLine("Main method end");
        }

    }
}