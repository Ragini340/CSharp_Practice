namespace CSharp_Practice.ExceptionHandlings.FinallyBlock
{
    public class FinallyBlockPOC
    {
        public static void FinallyBlockUses()
        {
            int num1, num2, result;
            try
            {
                Console.WriteLine("Enter the first number:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                num2 = int.Parse(Console.ReadLine());

                result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Second number should not be zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only integer numbers");
            }
            finally
            {
                Console.WriteLine("Hello, this is finally block");
            }
        }

        public static void Main(string[] args)
        {
            FinallyBlockUses();
        }

    }
}