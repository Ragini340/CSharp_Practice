using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Literals
{
    public class BinaryLiterals
    {
        // Creating binary literals by prefixing with 0b
        int Num1 = 0b100111101;
        int Num2 = 0b01000011;
        //int num3 = 0b100134; //Error

        public static void Main(string[] args)
        {
            BinaryLiterals binaryLiterals = new BinaryLiterals();
            Console.WriteLine($"Value of Num1 is: {binaryLiterals.Num1}");
            Console.WriteLine($"Value of Num2 is: {binaryLiterals.Num2}");
            Console.WriteLine($"Char value of Num1 is: {Convert.ToChar(binaryLiterals.Num1)}");
            Console.WriteLine($"Char value of Num2 is: {Convert.ToChar(binaryLiterals.Num2)}");
        }
    }
}