namespace CSharp_Practice.Asynchronous_Programming.Task_Class
{
    public class AsyncAndAwaitPOC
    {
        public async void Print()
        {
            Console.WriteLine("Print method started......");
            Wait();
            Console.WriteLine("Print method end");
        }

        private async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("10 seconds wait completed");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main method started......");
            AsyncAndAwaitPOC asyncAndAwaitPOC = new AsyncAndAwaitPOC();
            asyncAndAwaitPOC.Print();
            Console.WriteLine("Main method end");
            Console.ReadKey();
        }

    }
}