using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC
{
    public class ReverseOfString
    {
        public static string Reverse(string input)
        {
            //Converting string to character array
            char[] charArray = input.ToCharArray();

            //Declaring an empty string
            string reversedString = String.Empty;

            //Iterating the each character from right to left 
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                //Appending each character to the reversed string
                reversedString += charArray[i];
            }

            //Returning the reversed string
            return reversedString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Best"));
        }

    }
}
