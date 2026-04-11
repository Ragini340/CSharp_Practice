using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Literals
{
    public class StringLiterals
    {
        string str1 = "Honesty is the best policy";
        string str2 = @"Honesty is the best policy";
        string str3 = "Ragini\nKumari\tSingh";
        string str4 = @"Ragini\nKumari\tSingh";
        public static void Main(string[] args)
        {
            StringLiterals stringLiterals = new StringLiterals();
            Console.WriteLine($"str1: {stringLiterals.str1}");
            Console.WriteLine($"str2: {stringLiterals.str2}");
            Console.WriteLine($"str3: {stringLiterals.str3}");
            Console.WriteLine($"str4: {stringLiterals.str4}");
        }
    }
}