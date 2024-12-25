using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Cloning
{
    public class CallByReferenceDriver
    {
        public static void Main(string[] args)
        {
            CallByReferenceExample obj1 = new CallByReferenceExample();
            obj1.Name = "Ragini";
            obj1.Department = "IT";
            CallByReferenceExample obj2 = obj1;  //Here creating obj2 object from obj1.
            obj2.Name = "Susan"; //Changing Name of obj2 but it will also change the Name of obj1. 
            Console.WriteLine(obj1.Name); //Here Name obj1.Name will be Susan not Ragini because when we are assigning one object to
                                          //another object, it is by default call by reference and it will point to same memory.
        }
    }
}
