using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC.StringBuilder_POC
{
    public class StringBuilderReplace
    {
        public static void Main()
        {
            StringBuilder s = new StringBuilder("ABC defg ", 20);
            //Replace "ABC" with "Pqr xyz" 
            s.Replace("ABC", "Pqr xyz");
            Console.WriteLine(s);
        }

    }
}
