using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Literals
{
    public class BooleanLiterals
    {
        bool b1 = true;
        bool b2 = false;
        // bool b3 = 0; //Error
        // bool b4 = 1; //Error 

        public static void Main(string[] args)
        {
            BooleanLiterals booleanLiterals = new BooleanLiterals();
            Console.WriteLine(booleanLiterals.b1);
            Console.WriteLine(booleanLiterals.b2);
        }
    }
}