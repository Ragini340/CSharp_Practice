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
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 4, 3, 2, 6, 5 };
            Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

    }
}