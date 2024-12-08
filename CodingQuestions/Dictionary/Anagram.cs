using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Dictionary
{
    public class Anagram
    {
        public static bool IsAnagram(string str1, string str2)
        {
            Dictionary<char, int> dic1 = new Dictionary<char, int>();
            Dictionary<char, int> dic2 = new Dictionary<char, int>();

            for (int i = 0; i < str1.Length; i++)
            {
                char ch = str1[i];

                if (dic1.ContainsKey(ch))
                {
                    int currentCount = dic1[ch];
                    Console.WriteLine("Current count is ?"+currentCount+" "+ch);
                    dic1[ch] = currentCount + 1; //Overriding value with new value
                }
                else
                {
                    // dic1[ch] = 1;
                    dic1.Add(ch, 1);

                }
            }

            Console.WriteLine("dic1 elements are:");
            foreach (KeyValuePair<char, int> kvpdic1 in dic1)
            {
                Console.WriteLine("{0} {1}", kvpdic1.Key, kvpdic1.Value);
            }
            Console.WriteLine();

            for (int i = 0; i < str2.Length; i++)
            {
                char ch = str2[i];

                if (dic2.ContainsKey(ch))
                {
                    dic2[ch]++;
                }
                else
                {
                    dic2[ch] = 1;
                }
            }

            Console.WriteLine("dic2 elements are:");
            foreach (KeyValuePair<char, int> kvpsdic2 in dic2)
            {
                Console.WriteLine("{0} {1}", kvpsdic2.Key, kvpsdic2.Value);
            }
            Console.WriteLine();

            foreach (char character in dic2.Keys)
            {
                if (!dic2[character].Equals(dic1.ContainsKey(character) ? dic1[character] : 0))
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            string str1 = "geeks";
            string str2 = "kseeg";
            bool isAnagram = IsAnagram(str1, str2);
            Console.WriteLine(isAnagram);
        }

    }
}

