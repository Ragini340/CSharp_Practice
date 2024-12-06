using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC.Strings
{
    public class Palindrome
    {
        //Function to check if a string is a palindrome
        static int IsPalindrome(string s)
        {
            int len = s.Length;

            //Iterating over the first half of the string
            for (int i = 0; i < len / 2; i++)
            {
                //If the characters at symmetric positions are not equal
                if (s[i] != s[len - i - 1])
                {
                    return 0;
                }
            }

            //If all symmetric characters are equal then it is palindrome
            return 1;
        }

        static void Main()
        {
            string s = "abba";
            Console.WriteLine(IsPalindrome(s));
        }

    }
}
