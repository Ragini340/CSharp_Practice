namespace CSharp_Practice.CodingQuestions.Strings
{
    public class CountOccurrencesOfEachCharacterInString
    {
        public static void FindCountOfOccurrencesOfEachCharacter(string str)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            char[] arr = str.ToCharArray();

            foreach (char ch in arr)
            {
                if (ch != ' ')
                {
                    if (count.ContainsKey(ch))
                    {
                        count[ch]++;
                    }
                    else
                    {
                        count[ch] = 1;
                    }
                }
            }

            foreach (var item in count)
            {
                Console.WriteLine("Occurrences of " + item.Key + " = " + item.Value);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            FindCountOfOccurrencesOfEachCharacter(str);
        }

    }
}