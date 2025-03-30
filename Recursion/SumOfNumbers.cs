namespace CSharp_Practice.Recursion
{
    public class SumOfNumbers
    {
        public int FindSum(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return FindSum(n - 1) + n;
        }

        public static void Main(string[] args)
        {
            int n = 10;
            SumOfNumbers sumOfNumbers = new SumOfNumbers();
            int sum = sumOfNumbers.FindSum(n);
            Console.WriteLine(sum);
        }

    }
}