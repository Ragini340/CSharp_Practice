using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC
{
    /*Time Complexity: O(n), where n is the length of the input string.
    Auxiliary Space: O(1), no extra data structures used.*/
    public class StringPalindrome
    {
        //Function to check if a string is a palindrome
        static int IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            //Continuing looping while the two pointers have not crossed
            while (left < right)
            {
                // If the characters at the current position are not equal
                if (s[left] != s[right])
                {
                    return 0;
                }

                //Moving the left pointer to the right and the right pointer to the left
                left++;
                right--;
            }

            // If no mismatch is found, return 1 (palindrome)
            return 1;
        }

        static void Main()
        {
            string s = "abba";
            Console.WriteLine(IsPalindrome(s));
        }
    }
}
