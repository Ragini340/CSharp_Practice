using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC.Strings
{
    public class StringConcatanation
    {
        public static void Main()
        {
            string s1 = "Birds";
            string s2 = "of";
            string s3 = "a";
            string s4 = "feather";

            //Using concatenation operator
            string str = s1 + s2 + s3 + s4 + "flock";

            Console.WriteLine(str);
        }

    }
}
