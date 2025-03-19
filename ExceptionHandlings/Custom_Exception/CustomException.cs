namespace CSharp_Practice.ExceptionHandlings.Custom_Exception
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }

        public int InvalidAge { get; set; }

        public static void Main(string[] args)
        {
            try
            {
                int age = -5; 
                if (age < 0)
                {
                    throw new CustomException("Age cannot be negative.") { InvalidAge = age };
                }

                Console.WriteLine("Age is valid.");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Invalid age: {ex.InvalidAge}");
            }
        }

    }
}