namespace CSharp_Practice.Asynchronous_Programming
{
    public class ExampleWithAsyncAndAwait
    {
        public async void Print()
        {
            Console.WriteLine("Print method started......");
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine("\n");
            Console.WriteLine("Print method end");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main method started......");
            ExampleWithAsyncAndAwait withAsyncAndAwait = new ExampleWithAsyncAndAwait();
            withAsyncAndAwait.Print();
            Console.WriteLine("Main method end");
            Console.ReadKey(); //Here Console.ReadKey() is necessary to write otherwise it will not print "Print method end"
                               //statement of Print() on console.
        }

    }
}