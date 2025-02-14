namespace CSharp_Practice.CodingQuestions.Arrays
{
    public class SortTheArrayOfIntegers
    {
        public static int[] SortingIntegerArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 6, 0, 1 };
            int[] sortedArray = SortingIntegerArray(arr);
            Console.WriteLine("Sorted array elements: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
        }

    }
}