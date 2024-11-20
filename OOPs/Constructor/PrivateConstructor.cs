using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Constructor
{
    public class PrivateConstructor
    {
        //Declaring private constructor
        private PrivateConstructor()
        {
        }

        //Declaring static variable field
        public static int count;

        //Declaring static method
        public static int CountMethod()
        {
            return count++;
        }

    }
}
