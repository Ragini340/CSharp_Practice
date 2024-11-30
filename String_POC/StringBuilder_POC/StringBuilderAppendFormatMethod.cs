using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC.StringBuilder_POC
{
    public class StringBuilderAppendFormatMethod
    {
        public static void Main()
        {
            StringBuilder s = new StringBuilder("The total amount is: ");
            s.AppendFormat("{0:C} ", 50);
            Console.WriteLine(s);
        }

    }
}
