namespace CSharp_Practice.CodingQuestions
{
    public class CheckIfNumberDivisibleBy3And5
    {
        public static bool IsNumberDivisibleBy3And5(int num)
        {
            if (num % 15 == 0)
            {
                return true;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input number: ");
            int num = int.Parse(Console.ReadLine());
            bool result = IsNumberDivisibleBy3And5(num);
            Console.WriteLine("Is input number is divisible by 3 and 5? " + result);
        }

    }
}