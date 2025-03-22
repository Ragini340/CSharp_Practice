namespace CSharp_Practice.ExceptionHandlings.FinallyBlock
{
    public class Try_FinallyBlockWithoutCatchBlock
    {
        public static void TestMethod()
        {
            try
            {
                Console.WriteLine("Inside TestMethod");
                int num1 = 10, num2 = 0;
                int result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            finally
            {
                Console.WriteLine("TestMethod finally block");
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                TestMethod();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught");
            }
        }

    }
}