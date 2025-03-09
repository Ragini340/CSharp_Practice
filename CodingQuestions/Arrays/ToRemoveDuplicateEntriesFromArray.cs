namespace CSharp_Practice.CodingQuestions.Arrays
{
    public class ToRemoveDuplicateEntriesFromArray
    {
        public static void RemoveDuplicateEntriesFromArray(int[] arr)
        {
            HashSet<int> set = new HashSet<int>(arr);
            foreach (int num in set)
            {
                Console.Write(num + " ");
            }
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

            Console.WriteLine("After removing duplicate entries array elements are:");
            RemoveDuplicateEntriesFromArray(arr);
        }

    }
}