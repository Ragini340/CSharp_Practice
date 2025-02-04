namespace CSharp_Practice.CodingQuestions.Dictionary
{
    /*String Scramble
     Have the function StringScramble(str1, str2) take both parameters being passed and return the string true if a portion of 
     str1 characters can be rearranged to match str2, otherwise return the string false. For example if str1 is "rkqodlw" and str2
     is "world" the output should return true. Puctuation and symbols will not be entered with the parameters.
     Example:-
     Input: "cdore" & str2 = "coder"
     Oputput: true
     Input: "h3llko" & str2 = "hello"
     Output: false
     
     Time Complexity: O(n) if string length is n
     Space Complexity: O(n) because I am using Dictionary for storage.
    */
    public class StringScramble
    {
        public static string StringScrambles(string str1, string str2)
        {
            if (str2.Length > str1.Length)
            {
                return "false";
            }

            Dictionary<char, int> charCountMap1 = new Dictionary<char, int>();
            Dictionary<char, int> charCountMap2 = new Dictionary<char, int>();

            for (int i = 0; i < str1.Length; i++)
            {
                char ch = str1[i];
                if (charCountMap1.ContainsKey(ch))
                {
                    charCountMap1[ch]++;
                }
                else
                {
                    charCountMap1[ch] = 1;
                }
            }

            for (int i = 0; i < str2.Length; i++)
            {
                char ch = str2[i];
                if (charCountMap2.ContainsKey(ch))
                {
                    charCountMap2[ch]++;
                }
                else
                {
                    charCountMap2[ch] = 1;
                }

            }

            for (int i = 0; i < str2.Length; i++)
            {
                char ch = str2[i];
                if (!charCountMap1.ContainsKey(ch) || charCountMap2[ch] > charCountMap1[ch])
                {
                    return "false";
                }
            }
            return "true";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the two strings: ");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(StringScramble.StringScrambles(str1, str2));
        }
    }
}