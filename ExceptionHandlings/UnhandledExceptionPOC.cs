namespace CSharps_Practice.ExceptionHandlings
{
    public class UnhandledExceptionPOC
    {
        public static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(arr[7]);
        }

    }
}