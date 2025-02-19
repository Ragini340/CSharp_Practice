using Newtonsoft.Json;
using System.Diagnostics;

namespace CSharp_Practice.Asynchronous_Programming.Task_Class.LimitTheNumberOfConcurrentTasks.RealTimeExample
{
    public class LimitTheNumberOfConcurrentTasks_RealTimeEx
    {
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);

        public static List<CreditCard> GenerateCreditCards(int number)
        {
            List<CreditCard> creditCards = new List<CreditCard>();
            for (int i = 0; i < number; i++)
            {
                CreditCard card = new CreditCard()
                {
                    CardNumber = 10000000 + i,
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

            var Responses = await Task.WhenAll(tasks);
            List<CreditCardResponse> creditCardResponses = new List<CreditCardResponse>();
            foreach (var response in Responses)
            {
                CreditCardResponse creditCardResponse = JsonConvert.DeserializeObject<CreditCardResponse>(response);
                creditCardResponses.Add(creditCardResponse);
            }

            Console.WriteLine("\nApproved credit cards");
            foreach (var item in creditCardResponses.Where(card => card.IsProcessed == true))
            {
                Console.WriteLine($"Card number: {item.CardNumber}, Name: {item.Name}");
            }

            Console.WriteLine("\nRejected credit cards");
            foreach (var item in creditCardResponses.Where(card => card.IsProcessed == false))
            {
                Console.WriteLine($"Card number: {item.CardNumber}, Name: {item.Name}");
            }
        }

        public static async Task<string> ProcessCard(CreditCard creditCard)
        {
            await Task.Delay(1000);
            var creditCardResponse = new CreditCardResponse
            {
                CardNumber = creditCard.CardNumber,
                Name = creditCard.Name,
                IsProcessed = creditCard.CardNumber % 2 == 0 ? true : false
            };
            string jsonString = JsonConvert.SerializeObject(creditCardResponse);
            return jsonString;
        }

        public static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine($"Main thread started");
            List<CreditCard> creditCards = GenerateCreditCards(15);
            Console.WriteLine($"Credit card generated: {creditCards.Count}");
            ProcessCreditCards(creditCards);
            Console.WriteLine($"Main thread completed");
            Console.ReadKey();
        }

    }
}