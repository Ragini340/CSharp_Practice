using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Literals
{
    public class IntegerLiterals
    {
        /*Integer Literals*/

        // Decimal literal
        //Allowed Digits: 0 to 9	
        int a = 101; //No suffix is required
                     // Hexa-Decimal Literal
                     //Allowed Digits: 0 to 9 and Character a to f
        int b = 0x123f; //Prefix with 0x, and suffix with f
                        //Binary literal
                        //Allowed Digits: 0 to 1
        int c = 0b1111; //Prefix with 0b
        int d = 1000; //Integer
        uint e = 1000U; //Unsigned Integer
        long f = 1000L; //Long
        ulong g = 1000UL; //Unsigned Long

        /*Floating-Point Literals*/

        double h = 10.15; //By Default Floating Point Literal is double
                          //Float Literal	
        float i = 100.72F; //Suffix with F
                           //Double Literal
        double j = 1.45D; //Suffix with D
                          //Decimal Literal
        decimal k = 1.44M; //Suffix with M

        public static void Main(string[] args)
        {
            IntegerLiterals integerLiterals = new IntegerLiterals();

            Console.WriteLine($"Decimal Literal: {integerLiterals.a}");
            Console.WriteLine($"Hexa-Decimal Literal: {integerLiterals.b}");
            Console.WriteLine($"Binary Literal: {integerLiterals.c}");
            Console.WriteLine($"Integer Literal: {integerLiterals.d}");
            Console.WriteLine($"Unsigned Integer Literal: {integerLiterals.e}");
            Console.WriteLine($"Long Literal: {integerLiterals.f}");
            Console.WriteLine($"Unsigned Long Literal: {integerLiterals.g}");
            Console.WriteLine($"Double Literal: {integerLiterals.h}");
            Console.WriteLine($"Float Literal: {integerLiterals.i}");
            Console.WriteLine($"Double Literal: {integerLiterals.j}");
            Console.WriteLine($"Decimal Literal: {integerLiterals.k}");
        }
    }
}