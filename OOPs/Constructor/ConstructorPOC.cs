using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Constructor
{
    public class ConstructorPOC
    {
        //If we want to write only single line (Single statement) in a constructor then we can use arrow function as:
        //public ConstructorPOC() => Console.WriteLine("Deafult Constructor"); 
        int i;
        //If we are defining default constructor explicitely then the constructor is known as explicit constructor. Compiler implicitely defines only the default constructor, which is by default public and called implicit constructor.
        public ConstructorPOC() : this("Rag") //Calling other parametrized constructor with one parameter
        {
            //If we don't write any constructor in a class then by default when we create object of the class then the compiler will create default constructor.
            Console.WriteLine("Deafult constructor");
        }
        public ConstructorPOC(String str) :this(1, str)
        {
            //If we create object of class using parametrized constructor then we must need to define parametrized constructor in class with same type of argument.
            Console.WriteLine("I am parametrized constructor with one parameter of type string");
            return;
        }
        public ConstructorPOC(int empId, string str)
        {
            Console.WriteLine("I am parametrized constructor with 2 parameters" + empId + " " + str);
        }
        public static void Main()
        {
            //ConstructorPOC poc = new ConstructorPOC(1);  //Technical error will be thrown because there is no parametrized constructor with argument type integer.
            //ConstructorPOC poc = new ConstructorPOC("Ragini");
            ConstructorPOC constructorPOC = new ConstructorPOC();
            // Console.WriteLine(poc.i); //Default value of i will be zero. Default value for string type will be null and for bool type it will be false.
        }
    }
}
