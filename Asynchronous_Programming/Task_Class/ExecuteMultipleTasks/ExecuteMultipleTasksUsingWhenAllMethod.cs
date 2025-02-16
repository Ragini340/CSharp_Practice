using System.Diagnostics;

namespace CSharp_Practice.Asynchronous_Programming.Task_Class.ExecuteMultipleTasks
{
    public class ExecuteMultipleTasksUsingWhenAllMethod
    {
        public static List<CreditCard> GenerateCreditCards(int number)
        {
            List<CreditCard> creditCards = new List<CreditCard>();
            for (int i = 0; i < number; i++)
            {
                CreditCard card = new CreditCard()
                {
                    CardNumber = "10000000" + i,
                    Name = "CreditCard-" + i
                };
                creditCards.Add(card);
            }
            return creditCards;
        }

        public static async void ProcessCreditCards(List<CreditCard> creditCards)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var creditCard in creditCards)
            {
                var response = await ProcessCard(creditCard);
            }
            stopwatch.Stop();
            Console.WriteLine($"Processing of {creditCards.Count} credit cards done in {stopwatch.ElapsedMilliseconds / 1000.0} seconds");
        }
        

        public static async Task<string> ProcessCard(CreditCard creditCard)
        {

            await Task.Delay(1000);
            string message = $"Credit card number: {creditCard.CardNumber} Name: {creditCard.Name} processed";
            Console.WriteLine($"Credit card number: {creditCard.CardNumber} processed");
            return message;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"Main thread started");
            List<CreditCard> creditCards = ExecuteMultipleTasksUsingWhenAllMethod.GenerateCreditCards(10);
            Console.WriteLine($"Credit card generated : {creditCards.Count}");

            ProcessCreditCards(creditCards);

            Console.WriteLine($"Main thread completed");
            Console.ReadKey();
        }

    }
}