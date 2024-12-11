using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.StaticClassPOC
{
    public class DriverStaticDemo
    {
        public static void Main(String[] args)
        {
            /*Below code will through error when trying to create object of static class as: 
             Cannot declare variable of static type 'type'
            StaticDemo staticDemo = new StaticDemo();
            */
            StaticDemo.data = 100;
            StaticDemo.Print();
            StaticDemo.area(2); // We have two methods with same name area but with different no of paramaters called overloading,
                                // now which method will be called here? It will be decided by compiler with comparing with differences between these methods w.r.t
                                // no of parameter, return type, etc .. at compile time, so it is called compile time polymorphism.
        }
    }
}
