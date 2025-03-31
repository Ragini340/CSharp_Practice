namespace CSharp_Practice.CodingQuestions.Strings
{
    public class FindFirstNonRepeatingCharacterInAString
    {
        public static void FindFirstNonRepeatingCharacter(string str)
        {
            Dictionary<char, int> frequencyDic = new Dictionary<char, int>();

            foreach (char ch in str)
            {
                if (frequencyDic.ContainsKey(ch))
                {
                    frequencyDic[ch]++;
                }
                else
                {
                    frequencyDic[ch] = 1;
                }
            }

            foreach (char ch in str)
            {
                if (frequencyDic[ch] == 1)
                {
                    Console.WriteLine("First non-repeating character is: " + ch);
                    break;
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string");
            string str = Console.ReadLine();
            FindFirstNonRepeatingCharacter(str);
        }

    }
}