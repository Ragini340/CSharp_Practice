using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Strings
{
    //This program will reverse the whole sentence
    public class ReverseWholeSentence
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence: ");
            string str1 = Console.ReadLine();

            string[] arrStr = str1.Split(" ");
            string reverseWord1 = "";

            for (int i = arrStr.Length - 1; i >= 0; i--)
            {
                string reverseWord = "";
                reverseWord = reverseWord + arrStr[i];

                //If we don't have to use function Trim
                if (i == 0)
                {
                    reverseWord1 = reverseWord1 + reverseWord;
                }
                else
                {
                    reverseWord1 = reverseWord1 + reverseWord + " ";
                }
            }

            //reverseWord1 = reverseWord1.Trim(); 

            Console.WriteLine("Revered sentence is: " + reverseWord1);
            Console.WriteLine("Length of the revered sentence is: " + reverseWord1.Length);
        }

    }
}
