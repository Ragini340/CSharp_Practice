using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC.Strings
{
    public class StringCreationUsingConstructor
    {
        public static void Main()
        {
            char[] chars = { 'a', 'b', 'c', 'd', 'e' };

            //Creating a string from a character array
            string str1 = new string(chars);
            Console.WriteLine(str1);

            //Creating a string that consists of a character repeated 10 times
            string str2 = new string('a', 10);
            Console.WriteLine(str2);
        }

    }
}
