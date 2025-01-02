using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.Generic.WhatIsGeneric
{
    public class GenericsPOCDriver
    {
        public static void Main(string[] args)
        {
            bool isEqual = GenericsPOC.AreEqual(20.5, 20.5);
            if (isEqual)
            {
                Console.WriteLine("Both the numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers are not equal");
            }
        }
    }
}