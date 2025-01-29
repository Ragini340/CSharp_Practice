namespace CSharp_Practice.CodingQuestions.Arrays
{
    /*Program to split an array into two equal sum subarrays.
      Time Complexity: O(n2) 
      Space Complexity: O(1)
    */
    public class SplitArrayIntoTwoEqualSumSubarrays
    {
        public static int FindSplitPoint(int[] arr)
        {
            int leftSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                leftSum = leftSum + arr[i];
                int rightSum = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum = rightSum + arr[j];
                }

                if (leftSum == rightSum)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        public static void PrintTwoParts(int[] arr)
        {
            int splitPoint = FindSplitPoint(arr);
            Console.WriteLine("Two equal sum subarrays are:- ");
            for (int i = 0; i < splitPoint; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = splitPoint; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");

            //Or, we can print two splitted subarrays as:
            splitPoint = FindSplitPoint(arr);
            Console.WriteLine("Two equal sum subarrays are:- ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (splitPoint == i)
                {
                    Console.WriteLine();
                }
                Console.Write(arr[i] + " ");
            }
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 5 };
            PrintTwoParts(arr);
        }

    }
}