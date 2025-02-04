namespace CSharp_Practice.CodingQuestions.Arrays
{
    public class FindTheSumOfArrayElements
    {
        public void SumOfArrElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of the entered array elements is: " + sum);
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            FindTheSumOfArrayElements obj = new FindTheSumOfArrayElements();
            obj.SumOfArrElements(arr);
        }

    }
}