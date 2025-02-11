namespace CSharp_Practice.CodingQuestions.Arrays
{
    public class SortTheArrayOfAlphabets
    {
        public static string[] SortingArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (string.Compare(arr[j], arr[i]) < 0)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        public static void Main(string[] args)
        {
            string[] arr = { "c", "ab", "a", "e", "x" };
            string[] sortedArray = SortingArray(arr);
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
        }

    }
}