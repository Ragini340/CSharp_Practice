namespace CSharp_Practice.ExceptionHandlings.ExceptionHandling_Abuse
{
    public class PreventingExceptionHandlingAbuse
    {
        public static void PreventingExceptionAbuse()
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                int num1;
                //int.TryParse() will not throw an exception, instead returns false if the entered value cannot be converted to
                //integer
                bool IsValidFirstNumber = int.TryParse(Console.ReadLine(), out num1);
                if (IsValidFirstNumber)
                {
                    Console.WriteLine("Enter the second number");
                    int num2;
                    bool isValidNo = int.TryParse(Console.ReadLine(), out num2);

                    if (isValidNo && num2 != 0)
                    {
                        int result = num1 / num2;
                        Console.WriteLine($"Result = {result}");
                    }
                    else
                    {
                        if (isValidNo && num2 == 0)
                        {
                            Console.WriteLine("Second number cannot be zero");
                        }
                        else
                        {
                            Console.WriteLine($"Only numbers between {Int32.MinValue} && {Int32.MaxValue} are allowed");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Only numbers between {Int32.MinValue} && {Int32.MaxValue} are allowed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            PreventingExceptionAbuse();
        }

    }
}