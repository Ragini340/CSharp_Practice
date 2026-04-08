using System.Numerics;

namespace CSharp_Practice.CodingQuestions
{
    //Program to find even numbers in very large numbers with the best time complexity.
    /*
     The time complexity for checking if a number is even using number % 2 == 0 is O(1).
     The overall time complexity for checking all numbers in an array of size n is O(n), where n is the number of numbers in the array.
    */
    public class FindEvenNumbersInVeryLargeNumbers
    {
        public static bool IsEven(BigInteger number)
        {
            return number % 2 == 0;
        }

        public static void Main(string[] args)
        {
            BigInteger[] numbers = new BigInteger[]
            {
              BigInteger.Parse("1234567890123456789012345678901234567890"),
              BigInteger.Parse("1234567890123456789012345678901234567891"),
              BigInteger.Parse("1234567890123456789012345678901234567892"),
              BigInteger.Parse("9876543210987654321098765432109876543210")
            };

            Console.WriteLine("Even numbers are: ");
            foreach (BigInteger num in numbers)
            {
                if (IsEven(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

    }
}