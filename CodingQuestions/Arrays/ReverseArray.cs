namespace CSharp_Practice.CodingQuestions.Arrays
{
    public class ReverseArray
    {
        public static void Reverse(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left = left + 1;
                right = right - 1;
            }

            Console.WriteLine("Reversed array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
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

            Reverse(arr);
        }

    }
}