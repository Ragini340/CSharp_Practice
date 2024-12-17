﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Strings
{
    public class StringPalindrome
    {
        public static bool IsPalindromeString(string str)
        {
            str = str.ToLower();
            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str.ToCharArray()[i];
            }

            return str.Equals(reverse);
        }

        public static void Main(string[] args)
        {
            string str = "ara";
            bool result = IsPalindromeString(str);

            if (result)
            {
                Console.WriteLine(str + " is a palindrome");
            }
            else
            {
                Console.WriteLine(str + " is not a palindrome");
            }
        }

    }
}