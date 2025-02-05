namespace CSharp_Practice.Recursion
{
    public class StringReverseUsingRecursion
    {
        public static string ReverseString(string str, string result)
        {
            if (str.Length <= 1)
            {
                return result + str[str.Length - 1];
            }

            return ReverseString(str.Substring(0, str.Length - 1), result + str[str.Length - 1]);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string");
            string str = Console.ReadLine();
            string result = "";
            Console.Write(ReverseString(str, result));
        }

    }
}