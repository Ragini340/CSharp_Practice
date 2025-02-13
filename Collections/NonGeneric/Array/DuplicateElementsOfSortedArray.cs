namespace CSharp_Practice.Collections.NonGeneric.Array
{
    /*Time Complexity : O(log n)
     Space Complexity: O(1)*/
    public class DuplicateElementsOfSortedArray
    {
        public static int FindDuplicateElement(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 4 };
            int arrIndex = FindDuplicateElement(arr, arr.Length);
            if (arrIndex != -1)
            {
                Console.WriteLine("Duplicate element is : " + arr[arrIndex]);
            }
        }

    }
}
