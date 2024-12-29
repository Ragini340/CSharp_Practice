using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.BoxingUnboxing
{
    public class BoxingUnboxingPOC
    {
        public static void Main(string[] args)
        {
            int x = 10;
            object y = x;  //Here we are doing Boxing that is converting value type to a reference type.
            Console.WriteLine("y is: " + y);
            int z = (int)y; //Here we are doing Unboxing that is converting reference type to a value type.
            Console.WriteLine("z value is: " + z);
        }
    }
}
