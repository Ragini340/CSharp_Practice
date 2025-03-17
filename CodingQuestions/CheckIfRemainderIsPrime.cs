namespace CSharp_Practice.CodingQuestions
{
    public class CheckIfRemainderIsPrime
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
            Console.WriteLine("Enter the dividend: ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            int remainder = dividend % divisor;
            Console.WriteLine($"The remainder of {dividend} divided by {divisor} is: {remainder}");

            if (IsPrime(remainder))
            {
                Console.WriteLine($"\nThe remainder {remainder} is a prime number.");
            }
            else
            {
                Console.WriteLine($"\nThe remainder {remainder} is not a prime number.");
            }
        }

    }
}