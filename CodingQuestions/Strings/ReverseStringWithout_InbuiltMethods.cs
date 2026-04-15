using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Strings
{
    public class ReverseStringWithout_InbuiltMethods
    {
        public string ReverseString(string input)
        {
            char[] chars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                chars[i] = input[input.Length - 1 - i];
            }

            string reversed = new string(chars);
            return reversed;
        }

        public static void Main(string[] args)
        {
            ReverseStringWithout_InbuiltMethods obj = new ReverseStringWithout_InbuiltMethods();

            string input = "hello";
            string reversed = obj.ReverseString(input);

            Console.WriteLine(reversed);
        }
    }
}