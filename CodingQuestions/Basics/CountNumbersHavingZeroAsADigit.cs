namespace CSharp_Practice.CodingQuestions
{
    public class CountNumbersHavingZeroAsADigit
    {
        public static int CountNumbersHavingZeroTillTheGivenNumber(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i.ToString().Contains('0'))
                {
                    count++;
                }
            }
            return count;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The count of zeros occurring from 0 till the given number is: " + CountNumbersHavingZeroTillTheGivenNumber(num));
        }

    }
}