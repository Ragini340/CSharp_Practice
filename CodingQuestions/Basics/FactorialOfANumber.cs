using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Basics
{
    /* 
            *TIME COMPLEXITY: O(n)
            * Reason: The loop runs from 1 to num-1, performing a constant-time modulus check each time.
            * 
            * SPACE COMPLEXITY: O(1)
            * Reason: The algorithm uses a fixed amount of memory (the integer 'i') regardless of the input size.
    */
    public class FactorialOfANumber
    {
        public static void PrintFactors(int num)
        {
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    Console.Write(i + " ");
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factors of {num}:");
            PrintFactors(num);
        }
    }
}