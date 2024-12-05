using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Dictionary
{
    public class FindNonRepeatingCharacter
    {
        public static char? nonRepeatingCharacter(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }

            foreach (KeyValuePair<char, int> elements in dic)
            {
                Console.WriteLine("{0} {1}", elements.Key, elements.Value);
            }

            for (int i = 0; i < str.Length; i++)
            {
                char character = str[i];
                if (dic[character] == 1)
                {
                    return character;
                }
            }
            return null;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string name = Console.ReadLine();
            char? c = nonRepeatingCharacter(name);

            if (c.HasValue)
            {
                Console.WriteLine("First non repeating character is: " + c);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

    }
}
