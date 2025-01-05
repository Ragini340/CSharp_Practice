using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Dynamic_Programming
{
    //Program to find Longest Common Subsequence
    public class LongestCommonSubsequence
    {
        public int LCSRecursion(string s1, string s2, int i, int j)
        {
            if (i < 0 || j < 0)
            {
                return 0;
            }
            if (s1[i] == s2[j])
            {
                return 1 + LCSRecursion(s1, s2, i - 1, j - 1);
            }
            else
            {
                return Math.Max(LCSRecursion(s1, s2, i - 1, j), LCSRecursion(s1, s2, i, j - 1));
            }
        }

        public static void Main(string[] args)
        {
            string s1 = "abcd";
            string s2 = "aebd";
            LongestCommonSubsequence longestCommonSubsequence = new LongestCommonSubsequence();
            int longestSubsequene = longestCommonSubsequence.LCSRecursion(s1, s2, s1.Length - 1, s2.Length - 1);
            Console.WriteLine("Longest subsequence is: " + longestSubsequene);
        }
    }

}