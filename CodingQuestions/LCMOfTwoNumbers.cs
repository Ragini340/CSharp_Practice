using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions
{
    public class LCMOfTwoNumbers
    {
        public static void Main(string[] args)
        {
            int num1, num2, max, lcm;
            Console.WriteLine("Enter two numbers:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            max = (num1 > num2) ? num1 : num2;
            lcm = max;

            while ((lcm % num1 != 0) || (lcm % num2 != 0))
            {
                lcm = lcm + max;
            }
            Console.WriteLine("LCM of two numbers are: " +lcm);
        }
    }

}