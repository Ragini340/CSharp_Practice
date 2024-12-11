using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction
{
    public class DriverAbstractClassWithStaticMethod
    {
        public static void Main()
        {
            Implementor_AbstractClassWithStaticMethod obj = new Implementor_AbstractClassWithStaticMethod();

            //1.static method can't be called with object in C# as there is only one option to call static method that is using className 
            /*Error while trying to access Data method in below: Static member 'member'
            cannot be accessed with an instance reference; qualify it with a type name instead
            obj.Data();
            */

            AbstractClassWithStaticMethod.Data(); //Here the static Data method is called of Abstract class using class name and it is printing 
            //the message of Parent abstract class.

            Implementor_AbstractClassWithStaticMethod.Data(); //Here the static Data method is called of Derived class which is known as data hiding as
            //it is printing the message of Derived class not the Abstract class.
        }

    }
}
