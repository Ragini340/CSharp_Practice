using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC.StringBuilder_POC
{
    public class StringBuilderAppendMethod
    {
        public static void Main()
        {
            StringBuilder s = new StringBuilder("Hello ", 20);
            s.Append("abc");
            //AppendLine() method appends the string with a newline at the end.
            s.AppendLine("def");
            s.Append("ghi");
            Console.WriteLine(s);
        }

    }
}
