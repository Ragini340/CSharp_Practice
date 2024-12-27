using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Constructor
{
    public class StaticConstructor
    {
        public int i;
        public static int j;
        //Static constructor
        //The static constructors are never called explicitly, they are always called implicitly.
        static StaticConstructor()
        {
            // The following statement produces the first line of output, and the line occurs only once.
            Console.WriteLine("Static Constructor");
            //i = 100; //We cannot initialize non-static data members in Static constructor
            //Compile time error:- An object reference is required for the non-static field, method, or property 'member'
            j = 100;
        }
        //Default constructor
        public StaticConstructor()
        {
            //The non-static constructors are never called implicitly, they are always called explicitly.
            Console.WriteLine("Default constructor has been called");
        }

    }
}
