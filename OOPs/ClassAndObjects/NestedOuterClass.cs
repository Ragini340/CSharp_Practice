using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.ClassAndObjects
{
    public class NestedOuterClass
    {
        public void Method1()
        {
            Console.WriteLine("This is outer class method");
        }

        public class InnerClass
        {
            public void Method2()
            {
                Console.WriteLine("This is inner class method");
            }
        }

        public static void Main()
        {
            NestedOuterClass nestedOuterClass = new NestedOuterClass();
            nestedOuterClass.Method1();
            InnerClass innerClass = new InnerClass();
            innerClass.Method2();

            //Below code will also work for accessing the method of Inner clss
            /*NestedOuterClass.InnerClass innerClass1 = new NestedOuterClass.InnerClass();
            innerClass1.Method2();*/
        }

    }
}
