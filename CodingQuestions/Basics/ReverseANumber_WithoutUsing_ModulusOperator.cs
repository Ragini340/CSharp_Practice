namespace CSharp_Practice.CodingQuestions
{
    public class ReverseANumber_WithoutUsing_ModulusOperator
    {
        public static int ReverseNumber(int number)
        {
            string str = number.ToString();
            char[] numberArr = str.ToCharArray();
            Array.Reverse(numberArr);
            string reversedString = new string(numberArr);
            return int.Parse(reversedString);
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int reversedNumber = ReverseNumber(number);
            Console.WriteLine("Reversed number is: " + reversedNumber);
        }

    }
}