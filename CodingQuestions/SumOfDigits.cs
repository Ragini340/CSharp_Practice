namespace CSharp_Practice.CodingQuestions
{
    public class SumOfDigits
    {
        public static void FindSumOfDigits(int num)
        {
            int sum = 0;
            int remainder;

            while (num > 0)
            {
                remainder = num % 10; 
                num = num / 10;
                sum = sum + remainder;   
            }

            Console.Write("Sum of the digits of the entered number is: " + sum);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            SumOfDigits.FindSumOfDigits(number);
        }

    }
}