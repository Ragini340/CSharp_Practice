using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC.StringBuilder_POC
{
    public class StringBuilderInsertMethod
    {
        public static void Main()
        {
            StringBuilder s = new StringBuilder("Hello ", 20);
            //"Abc" insert after 6th index 
            s.Insert(6, "Abc");
            Console.WriteLine(s);
        }

    }
}
