namespace CSharp_Practice.ExceptionHandlings.Custom_Exception
{
    public class CustomExceptionPOC : Exception
    {
        public override string Message
        {
            get
            {
                return "Divisor Cannot be Odd Number";
            }
        }

        public override string HelpLink
        {
            get
            {
                return "Get More Information from here: https://github.com/Ragini340";
            }
        }

        public static void CustomException()
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number:");
                Number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Number:");
                Number2 = int.Parse(Console.ReadLine());

                if (Number2 % 2 > 0)
                {
                    throw new CustomExceptionPOC();
                }
                Result = Number1 / Number2;
                Console.WriteLine(Result);
            }
            catch (CustomExceptionPOC one)
            {
                Console.WriteLine($"Message: {one.Message}");
                Console.WriteLine($"HelpLink: {one.HelpLink}");
                Console.WriteLine($"Source: {one.Source}");
                Console.WriteLine($"StackTrace: {one.StackTrace}");
            }
        }

        public static void Main(string[] args)
        {
            CustomException();
            Console.WriteLine("End of the Program");
        }

    }
}