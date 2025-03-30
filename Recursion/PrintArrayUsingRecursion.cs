namespace CSharp_Practice.Recursion
{
    public class PrintArrayUsingRecursion
    {
        public void PrintArrayElements(int[] arr, int k)
        {
            if (arr.Length - 1 == k)
            {
                Console.WriteLine(arr[k]);
                return;
            }
            Console.Write(arr[k] + " ");
            PrintArrayElements(arr, k + 1);
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            PrintArrayUsingRecursion printArrayUsingRecursion = new PrintArrayUsingRecursion();
            printArrayUsingRecursion.PrintArrayElements(arr, 0);
        }

    }
}