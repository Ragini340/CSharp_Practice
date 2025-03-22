using System.Text;

namespace CSharp_Practice.ExceptionHandlings.Inner_Exception
{
    public class InnerException
    {
        public static void InnerExceptionPOC()
        {
            try
            {
                int FirstNumber, SecondNumber, Result;
                try
                {
                    Console.WriteLine("Enter the first number:");
                    FirstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number:");
                    SecondNumber = int.Parse(Console.ReadLine());

                    Result = FirstNumber / SecondNumber;
                    Console.WriteLine($"Result = {Result}");
                }
                catch (Exception ex)
                {
                    string filePath = @"D:\Ragini\LogFile\Log.txt";
                    if (File.Exists(filePath))
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append($"Message: {ex.Message} \n");
                        stringBuilder.Append($"Source: {ex.Source} \n");
                        stringBuilder.Append($"HelpLink: {ex.HelpLink} \n");
                        stringBuilder.Append($"StackTrace: {ex.StackTrace} \n");
                        stringBuilder.Append($"GetType(): {ex.GetType()} \n");
                        stringBuilder.Append($"GetType().Name: {ex.GetType().Name} \n");

                        StreamWriter streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(stringBuilder.ToString());
                        streamWriter.Close();
                        Console.WriteLine("There is a problem! please try later");
                    }
                    else
                    {
                        string Message = filePath + " does not exist";
                        throw new FileNotFoundException(Message, ex);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("\nCurrent exception details: ");
                Console.WriteLine($"Current exception Message: {exception.Message}");
                Console.WriteLine($"Current exception Source: {exception.Source}");
                Console.WriteLine($"Current exception StackTrace: {exception.StackTrace}");

                if (exception.InnerException != null)
                {
                    Console.WriteLine("\nInner exception details: ");
                    Console.WriteLine($"Inner exception Message: {exception.InnerException.Message}");
                    Console.WriteLine($"Inner exception Source: {exception.InnerException.Source}");
                    Console.WriteLine($"Inner exception StackTrace: {exception.InnerException.StackTrace}");
                }
            }
        }

        public static void Main(string[] args)
        {
            InnerExceptionPOC();
            Console.WriteLine("Main method ended");
        }

    }
}