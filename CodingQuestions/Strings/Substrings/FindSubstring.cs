using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Strings.Substrings
{
    //Program to find substring in a string
    public class FindSubstring
    {
        public static void Main(string[] args)
        {
            string str = "Ragini Singh";
            string substr1 = str.Substring(0, 6); //Substring(Int32, Int32) - Retrieves a substring from this instance from the specified position for the specified length.
            string substr2 = str.Substring(7); //Substring(Int32) - Retrieves a substring from the specified position to the end of the string.
            Console.WriteLine(substr1);
            Console.WriteLine(substr2);
        }
    }
}
