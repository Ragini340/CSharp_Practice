namespace CSharp_Practice.CodingQuestions
{
    public class SwapTwoNums_WithoutThirdVariable
    {
        public static void SwapTwoNums(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swap num1 is: " + a + "\n" + "After swap num2 is: " + b);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            SwapTwoNums(num1, num2);
        }

    }
}