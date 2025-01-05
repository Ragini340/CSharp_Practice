namespace CSharp_Practice.CodingQuestions
{
    public class CheckForPrimeNo
    {
        public static bool IsPrime(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Is entered number is prime?" + " " + IsPrime(N));
        }
    }

}