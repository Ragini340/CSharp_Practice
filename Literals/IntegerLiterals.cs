using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Literals
{
    public class IntegerLiterals
    {
        public static void Main(string[] args)
        {
            // Decimal literal
            //Allowed Digits: 0 to 9	
            int a = 101; //No suffix is required
            // Hexa-Decimal Literal
            //Allowed Digits: 0 to 9 and Character a to f
            int c = 0x123f; //Prefix with 0x, and suffix with f
            //Binary literal
            //Allowed Digits: 0 to 1
            int d = 0b1111; //Prefix with 0b
            Console.WriteLine($"Decimal Literal: {a}");
            Console.WriteLine($"Hexa-Decimal Literal: {c}");
            Console.WriteLine($"Binary Literal: {d}");
        }
    }
}