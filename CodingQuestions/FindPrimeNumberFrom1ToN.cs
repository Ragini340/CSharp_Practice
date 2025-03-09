namespace CSharp_Practice.CodingQuestions
{
    public class FindPrimeNumberFrom1ToN
    {
        public static bool IsPrime(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
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
            Console.WriteLine("Enter the value of n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime numbers from 1 to " + n + " are:");
            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

    }
}