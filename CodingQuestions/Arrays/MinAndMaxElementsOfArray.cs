namespace CSharp_Practice.CodingQuestions.Arrays
{
    public class MinAndMaxElementsOfArray
    {
        public static void FindMinMaxArrElements(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }

        public static void Main(string[] args)
        {
            int[] arr = { 10, 30, 40, 100, 170, 50, 20, 60 };
            FindMinMaxArrElements(arr);
        }

    }
}