namespace CSharp_Practice.Asynchronous_Programming.Task_Class
{
    public class AsyncWithAwaitOperatorPOC
    {
        public async void Print()
        {
            Console.WriteLine("Print method started......");
            await Wait();
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
            AsyncWithAwaitOperatorPOC asyncWithAwaitOperator = new AsyncWithAwaitOperatorPOC();
            asyncWithAwaitOperator.Print();
            Console.WriteLine("Main method end");
            Console.ReadKey();
        }

    }
}