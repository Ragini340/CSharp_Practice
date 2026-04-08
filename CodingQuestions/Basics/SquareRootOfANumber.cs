namespace CSharp_Practice.CodingQuestions
{
    public class SquareRootOfANumber
    {
        public static void FindSquareRootOfANumber(int num)
        {
            int squareRoot = (int)Math.Sqrt(num);
            Console.WriteLine($"The square root of {num} is: {squareRoot}");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            FindSquareRootOfANumber(num);
        }

    }
}