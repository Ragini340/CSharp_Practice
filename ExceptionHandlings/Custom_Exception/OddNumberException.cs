namespace CSharp_Practice.ExceptionHandlings.Custom_Exception
{
    public class OddNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "Divisor cannot be odd number";
            }
        }

        public override string HelpLink
        {
            get
            {
                return "Get more information from here: https://github.com/Ragini340";
            }
        }

        public static void CustomException()
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter the first number:");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                Number2 = int.Parse(Console.ReadLine());

                if (Number2 % 2 > 0)
                {
                    throw new OddNumberException();
                }
                Result = Number1 / Number2;
                Console.WriteLine(Result);
            }
            catch (OddNumberException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"HelpLink: {ex.HelpLink}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
        }

        public static void Main(string[] args)
        {
            CustomException();
            Console.WriteLine("End of the program");
        }

    }
}