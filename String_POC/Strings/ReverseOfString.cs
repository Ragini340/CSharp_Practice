namespace CSharp_Practice.String_POC.Strings
{
    public class ReverseOfString
    {
        public static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            string reversedString = string.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }

            return reversedString;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string:");
            string str = Console.ReadLine();
            Console.WriteLine("Reversed string is: " + Reverse(str));
        }

    }
}