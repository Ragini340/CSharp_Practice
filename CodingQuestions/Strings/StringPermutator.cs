using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Strings
{
    
    /* Generates all permutations of a string.
       Time Complexity: O(n * n!) — n! permutations, each taking O(n) to create a string
       Space Complexity: O(n * n!) — to store all permutations; recursion stack: O(n)
    */
    public class StringPermutator
    {
        public static void GeneratePermutations(string str)
        {
            Permute(str.ToCharArray(), 0);
        }

        private static void Permute(char[] chars, int start)
        {
            if (start == chars.Length - 1)
            {
                Console.WriteLine(new string(chars));
                return;
            }

            for (int i = start; i < chars.Length; i++)
            {
                Swap(chars, start, i);
                Permute(chars, start + 1);
                Swap(chars, start, i); // backtrack
            }
        }

        private static void Swap(char[] chars, int i, int j)
        {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("All permutations of a string ABC are: ");
            StringPermutator.GeneratePermutations("ABC");
        }
    }
}