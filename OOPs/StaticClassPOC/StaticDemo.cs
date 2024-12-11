using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.StaticClassPOC
{
    public static class  StaticDemo
    {
        public static int data;
        /*Below constructor cannot be created
        StaticDemo()
        {
          Console.WriteLine("We cannot create the constructor of static class");
        }
        */


        //Area of recctange
        public  static int area(int a,int b)
        {
            return a * b;
        }

        //Area of square
        public static int area(int a)
        {
            return a * a;
        }

        public static void Print()
        {
            Console.WriteLine("Static method");
        }
    }
}
