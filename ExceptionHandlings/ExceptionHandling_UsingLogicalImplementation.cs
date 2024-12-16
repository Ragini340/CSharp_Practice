using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.ExceptionHandlings
{
    public class ExceptionHandling_UsingLogicalImplementation
    {
        public static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, result;
            Console.WriteLine("Enter the first number:");
            Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            Console.ReadLine();

            if (num2 == 0)
            {
                Console.WriteLine("num2 should not be zero");
            }
            else
            {
                result = num1 / num2;
                Console.WriteLine(result);
            }
        }
    }
}
