namespace CSharp_Practice.Asynchronous_Programming.Task_Class.ReturnValue_FromTask
{
    public class TaskWithErrors
    {
        public async static void Print(string Name)
        {
            Console.WriteLine("Print method started......");
            var GreetingSMessage = await Greetings(Name);
            Console.WriteLine($"\n{GreetingSMessage}");
            Console.WriteLine("Some method end");
        }

        public static async Task<string> Greetings(string Name)
        {
            string message = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44357/");
                HttpResponseMessage response = await client.GetAsync($"api/greetings2/{Name}");
                response.EnsureSuccessStatusCode();
                message = await response.Content.ReadAsStringAsync();
            }
            return message;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main method started......");
            Console.WriteLine("Enter the Name: ");
            string Name = Console.ReadLine();
            Print(Name);
            Console.WriteLine("Main method end");
            Console.ReadKey();
        }

    }
}