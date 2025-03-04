namespace CSharp_Practice.CodingQuestions.Strings
{
    public class ReverseString_Without_Affecting_SpecialCharacters
    {
        public static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            int left = 0;
            int right = charArray.Length - 1;

            while (left < right)
            {
                if (!char.IsLetter(charArray[left]))
                {
                    left = left + 1;
                }
                else if (!char.IsLetter(charArray[right]))
                {
                    right = right - 1;
                }
                else
                {
                    char temp = charArray[left];
                    charArray[left] = charArray[right];
                    charArray[right] = temp;
                    left = left + 1;
                    right = right - 1;
                }
            }

            return new string(charArray);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string:");
            string str = Console.ReadLine();
            Console.WriteLine("Reversed string is: " + ReverseString(str));
        }

    }
}