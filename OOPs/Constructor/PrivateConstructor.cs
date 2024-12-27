using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Constructor
{
    public class PrivateConstructor
    {
        /*Using Private Constructor we can implement the singleton design pattern.
        We need to use the private constructor when the class contains only static members.
        Using a private constructor it is not possible to create an instance from outside the class.
         */
        //Declaring private constructor
        private PrivateConstructor()
        {
            Console.WriteLine("Private constructor");
        }

        public static void Main()
        {
            PrivateConstructor privateConstructor = new PrivateConstructor();
            Console.WriteLine("Main method");
        }
    }
}
