using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC.StringBuilder_POC
{
    public class StringBuilderRemoveMethod
    {
        public static void Main()
        {
            StringBuilder s = new StringBuilder("Abcdefghi", 20);
            //Remove starts from index 5 and remove happes 3 index after index 5 
            s.Remove(5, 3);
            Console.WriteLine(s);
        }

    }
}
