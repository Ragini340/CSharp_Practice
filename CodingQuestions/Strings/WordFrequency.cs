using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Strings
{
    //Program to find frequency of words in a sentence
    public class WordFrequency
    {
        static void FrequencyOfWord(String str)
        {
            Dictionary<String, int> dictionary = new Dictionary<String, int>();
            String[] arr = str.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (dictionary.ContainsKey(arr[i]))
                {
                    dictionary[arr[i]] = dictionary[arr[i]] + 1;
                }
                else
                {
                    dictionary.Add(arr[i], 1);
                }
            }

            foreach (KeyValuePair<String, int> kvp in dictionary)
            {
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the string: ");
            String str = Console.ReadLine();

            Console.WriteLine("Word's frequency are: ");
            FrequencyOfWord(str);
        }

    }
}
