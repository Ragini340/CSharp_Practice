namespace CSharp_Practice.Asynchronous_Programming.RetryPattern
{
    public class RetryPattern_POC
    {
        public static async void RetryMethod()
        {
            var RetryTimes = 3;
            var WaitTime = 500;

            for (int i = 0; i < RetryTimes; i++)
            {
                try
                {
                    await RetryOperation();
                    Console.WriteLine("Operation is successful");
                    break;
                }
                catch (Exception Ex)
                {
                    Console.WriteLine($"Retry {i + 1}: Getting Exception : {Ex.Message}");
                    await Task.Delay(WaitTime);
                }
            }
        }

        public static async Task RetryOperation()
        {
            await Task.Delay(500);
            throw new Exception("Exception occurred while processing...");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main method started");
            RetryMethod();
            Console.WriteLine("Main method completed");
            Console.ReadKey();
        }

    }
}