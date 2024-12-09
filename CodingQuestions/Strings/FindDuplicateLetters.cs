using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Strings
{
    /*Write a program to find duplicate letter using Dictionary*/
    public class FindDuplicateLetters
    {
        public static void Main(string[] args)
        {
            string str1 = "GeeksforGeeks";
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char c in str1)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c]++;
                }
                else
                {
                    dictionary[c] = 1;
                }
            }

            Console.WriteLine("Duplicate characters and their counts are:");
            foreach (KeyValuePair<char, int> kvps in dictionary)
            {
                if (kvps.Value > 1)
                {
                    Console.WriteLine("{0} {1}", kvps.Key, kvps.Value);
                }
            }

        }

    }
}
