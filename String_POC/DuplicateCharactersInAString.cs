using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC
{
    public class DuplicateCharactersInAString
    {
        public static void Main()
        {
            string inputString = "Hello";
            int[] count = new int[256];

            Console.WriteLine("Duplicate characters in the string and their counts are:");

            foreach (char c in inputString)
            {
                count[c] = count[c] + 1;
            }

            for (int i = 0; i < 256; i++)
            {
                if (count[i] > 1)
                {
                    Console.WriteLine($"Character: {(char)i}, Count: {count[i]}");
                }
            }
        }

    }
}
