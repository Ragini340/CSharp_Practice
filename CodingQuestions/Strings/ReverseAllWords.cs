using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Strings
{
    //This program will reverse the words of a whole sentence
    public class ReverseAllWords
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the sentence: ");
            string str1 = Console.ReadLine();

            string[] arrStr = str1.Split(" ");
            string reverseWord1 = "";

            for (int i = 0; i <= arrStr.Length - 1; i++)
            {
                string word = arrStr[i];
                string reverseWord = "";

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reverseWord = reverseWord + word[j];
                }
             
                reverseWord1 = reverseWord1 + reverseWord + " ";
            }

            reverseWord1 = reverseWord1.Trim();
            Console.WriteLine("Reversed sentence's word are: " + reverseWord1);
            Console.WriteLine("Length of the revered sentence is: " + reverseWord1.Length);
        }

    }
}