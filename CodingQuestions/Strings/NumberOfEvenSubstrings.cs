using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Strings
{
    //Number of even substrings in a string of digits
    //https://www.geeksforgeeks.org/number-of-even-substrings-in-a-string-of-digits/

    /*Given a string S consisting of digits between 1 and 9. Rearrange the string such that the number of Even Unique Substring 
     * it contains is maximized. A substring is said to be even if the number it represents is even. Two substrings are considered same
     * if and only if their starting and ending indices are equal. Return the number of even substrings present in the string  S after 
     * rearranging it such that number of Even Unique Substring is maximized.
     * Input:- S is a string
     * Output:- Output must be positive number
     * Constraints:- 1 <= Length of S <= 1000
     * String S only contains digits between 1 and 9 (both inclusive).
     * Example:- 
     * Input:- 1232
     * Output:- 7
     * Explanation:- We will rearrange the string to "1322". Now, the seven even substrings are:-
     * "132", "1322", "322", "32", "22", "2", "2"
     */
    public class NumberOfEvenSubstrings
    {
        public static int EvenSubstrings(string str)
        {
            string evenSubstring = "";
            string oddSubstring = "";

            for (int i = 0; i < str.Length; i++)
            {
                int digit = str[i] - '0';
                if (digit % 2 == 0)
                {
                    evenSubstring = evenSubstring + str[i];
                }
                else
                {
                    oddSubstring = oddSubstring + str[i];
                }
            }

            str = oddSubstring + evenSubstring; 
            Console.WriteLine("Rearranged substring is: " + str);
            int len = str.Length;
            int count = 0;
            for (int i = 0; i < len; i++)
            {
                int temp = str[i] - '0'; //Converting character of string to integer
                //If current digit is even then add count of substrings ending with it.
                //The count is (i+1)
                if (temp % 2 == 0)
                {
                    count = count + (i + 1);
                }
            }
            return count;
        }

        public static void Main(string[] args)
        {
            string str = "1234";
            Console.WriteLine(EvenSubstrings(str));
        }

    }
}
