namespace CSharp_Practice.Asynchronous_Programming.Task_Class.ReturnValue_FromTask
{
    //Calling Web API HTTP request from Console Application
    public class ReturnValueFromTask
    {
        public async static void Print(string Name)
        {
            Console.WriteLine("Print method started......");
            var GreetingSMessage = await Greetings(Name);
            Console.WriteLine($"\n{GreetingSMessage}");
            Console.WriteLine("Print method end");
        }

        public static async Task<string> Greetings(string Name)
        {
            string message = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/");
                HttpResponseMessage response = await client.GetAsync($"api/greetings/{Name}");
                message = await response.Content.ReadAsStringAsync();
            }
            return message;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main method started......");
            Console.WriteLine("Enter the name: ");
            string Name = Console.ReadLine();
            Print(Name);
            Console.WriteLine("Main method end");
            Console.ReadKey();
        }

    }
}