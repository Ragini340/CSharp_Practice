namespace CSharp_Practice.Recursion
{
    public class Factorial
    {
        public int FindFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return FindFactorial(n - 1) * n;
        }

        public static void Main(string[] args)
        {
            int n = 5;
            Factorial factorial = new Factorial();
            int fact = factorial.FindFactorial(n);
            Console.WriteLine(fact);
        }

    }
}