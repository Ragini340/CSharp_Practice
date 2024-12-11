using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction
{
    public class Implementor_AbstractClassWithStaticMethod : AbstractClassWithStaticMethod
    {
        /*Here static method Data cannot be marked as override as static methods are called using className.static method name*/
        public static void Data()  //This method is not overriden from parent abstract class this will consider as a there own static method.
        {
            Console.WriteLine("A static method cannot be marked as override");
        }
    }
}
