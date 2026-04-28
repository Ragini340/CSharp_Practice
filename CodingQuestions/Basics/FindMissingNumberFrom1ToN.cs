using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Basics
{
    /*Time Complexity: O(n)
      Space Complexity:
      Auxiliary: O(1)
      Total: O(n)
    */
    public class FindMissingNumberFrom1ToN
    {
        public static int FindMissingNumber(int[] arr, int n)
        {
            int expected = n * (n + 1) / 2;

            int actual = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                actual = actual + arr[i];
            }

            return expected - actual;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Elements of array are:-");
            for (int i = 0; i < length; i++)
            {
                Console.Write("Array element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int n = length + 1;

            int missing = FindMissingNumber(arr, n);

            Console.WriteLine("Missing number: " + missing);
        }
    }
}