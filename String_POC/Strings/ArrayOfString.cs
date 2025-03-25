namespace CSharp_Practice.String_POC.Strings
{
    public class ArrayOfString
    {
        public static void ArrOfString(string[] str_arr)
        {
            for (int i = 0; i < str_arr.Length; i++)
            {
                Console.WriteLine("Value at index position" + i + " is " + str_arr[i]);
            }
        }

        public static void Main(string[] args)
        {
            string[] str_arr = new string[3];
            // Initialising the array of strings
            str_arr[0] = "Ab";
            str_arr[1] = "Cd";
            str_arr[2] = "Ef";
            ArrOfString(str_arr);
        }

    }
}