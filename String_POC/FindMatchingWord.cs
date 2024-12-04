using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC
{
    public class FindMatchingWord
    {
        public static bool IsMatched(string str1, string str2)
        {
            Dictionary<char, int> s1 = new Dictionary<char, int>();
            Dictionary<char, int> s2 = new Dictionary<char, int>();

            for (int i = 0; i < str1.Length; i++)
            {
                char ch = str1[i];

                if (char.IsLetter(ch))
                {
                    if (s1.ContainsKey(ch))
                    {
                        s1[ch]++;
                    }
                    else
                    {
                        s1[ch] = 1;
                    }
                }
            }

            for (int i = 0; i < str2.Length; i++)
            {
                char ch = str2[i];
                if (char.IsLetter(ch))
                {
                    if (s2.ContainsKey(ch))
                    {
                        s2[ch]++;
                    }
                    else
                    {
                        s2[ch] = 1;
                    }
                }
            }

            foreach (char character in s2.Keys)
            {
                if (!s2[character].Equals(s1.ContainsKey(character) ? s1[character] : 0))
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            string str1 = "h3llko";
            string str2 = "hello.";
            bool result = IsMatched(str1, str2);

            Console.WriteLine(result);
        }

    }
}
