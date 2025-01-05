namespace CSharp_Practice.CodingQuestions
{
    //Program to find the next prime number
    public class CheckNearestPrimeNo
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

        public static int NextPrimeNo(int num)
        {
            if (num <= 1)
            {
                return 2;
            }

            int prime = num;
            bool nextPrime = false;
            while (!nextPrime)
            {
                prime = prime + 1;
                if (IsPrime(prime))
                {
                    nextPrime = true;
                }
            }
            return prime;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Nearest prime number is:- " + NextPrimeNo(num));
        }
    }

}