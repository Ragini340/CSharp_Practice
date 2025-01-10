namespace CSharp_Practice.CodingQuestions.Strings
{
    //Program to count occurrence of a given character in a string
    /*Time Complexity: O(n), where n is the size of the string given.
      Space Complexity: O(1)*/
    public class OccurrenceOfCharacterInAString
    {
        public static int OccurrenceOfCharacter(string str, char ch)
        {
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    result = result + 1;
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
            string str = "Assembly";
            char ch = 's';
            int result = OccurrenceOfCharacter(str, ch);
            Console.WriteLine("Occurrence of s in Assembly is: " + result);
        }
    }

}