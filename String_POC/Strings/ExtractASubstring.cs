using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC.Strings
{
    public class ExtractASubstring
    {
        public static void Main()
        {
            string sentence = "Birds of a feather flock together";

            //Extracting the second word taking the first space position value
            int startPosition = sentence.IndexOf(" ") + 1;

            //Taking the second space position value
            int endPosition = sentence.IndexOf(" ", startPosition) - startPosition;

            //Now extracting second word from the sentence
            string word = sentence.Substring(startPosition, endPosition);
            Console.WriteLine(word);
        }

    }
}
