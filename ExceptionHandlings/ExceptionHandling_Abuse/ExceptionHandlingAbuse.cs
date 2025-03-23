namespace CSharp_Practice.ExceptionHandlings.ExceptionHandling_Abuse
{
    public class ExceptionHandlingAbuse
    {
        public static void ExceptionHandlingsAbuse()
        {
            try
            {
                Console.WriteLine("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"Result = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Only numbers between {Int32.MinValue} & {Int32.MaxValue} are allowed");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Second number cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            ExceptionHandlingsAbuse();
        }

    }
}