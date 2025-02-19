using System.Diagnostics;

namespace CSharp_Practice.Asynchronous_Programming.Task_Class.LimitTheNumberOfConcurrentTasks
{
    public class HandleResponseWithMultipleTasksUsingWhenAllMethod
    {
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);

        public static List<CreditCard> GenerateCreditCards(int number)
        {
            List<CreditCard> creditCards = new List<CreditCard>();
            for (int i = 0; i < number; i++)
            {
                CreditCard card = new CreditCard()
                {
                    CardNumber = "10000000" + i,
                    Name = "CreditCard" + i
                };

                creditCards.Add(card);
            }

            return creditCards;
        }

        public static async void ProcessCreditCards(List<CreditCard> creditCards)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var tasks = new List<Task<string>>();
            tasks = creditCards.Select(async card =>
            {
                await semaphoreSlim.WaitAsync();
                try
                {
                    return await ProcessCard(card);
                }
                finally
                {
                    semaphoreSlim.Release();
                }
            }).ToList();

            string[] Responses = await Task.WhenAll(tasks);
            foreach (var response in Responses)
            {
                Console.WriteLine(response);
            }

            stopwatch.Stop();
            Console.WriteLine($"Processing of {creditCards.Count} credit cards done in {stopwatch.ElapsedMilliseconds / 1000.0} seconds");
        }

        public static async Task<string> ProcessCard(CreditCard creditCard)
        {
            await Task.Delay(1000);
            string message = $"Credit card number: {creditCard.CardNumber} Name: {creditCard.Name} processed";
            return message;
        }

        public static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine($"Main thread started");
            List<CreditCard> creditCards = HandleResponseWithMultipleTasksUsingWhenAllMethod.GenerateCreditCards(15);
            Console.WriteLine($"Credit card generated: {creditCards.Count}");
            ProcessCreditCards(creditCards);
            Console.WriteLine($"Main thread completed");
            Console.ReadKey();
        }

    }
}