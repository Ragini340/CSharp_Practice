using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Constructor
{
    public class ConstructorPOC
    {
        //public ConstructorPOC() => Console.WriteLine("Deafult Constructor"); //If we want to write only line (Single statement)in constructor we can use arrow function.
        int i;
       
       //We are defining default constructor explicitely and it is called explicit constructor. Complired implecitky defined only default constructor which by default public and called implict constructor .
       public ConstructorPOC() {   //If we don't write any constructor in class by default when create object compiler will create default construtor 
           Console.WriteLine("Deafult Constructor");  
            //But If we create object of class using parameetrized constructor then we must need to defined parametrized constructor in class with same type of argument . Check with removing all constructor and create object with passing some parameter 
        }

        public ConstructorPOC(String str)
        {
            Console.WriteLine("I am parametrized constructor with one parameter of Type string ");
            return;
        }
        
        public static void Main()
        {
            //  ConstructorPOC poc= new ConstructorPOC(int);  // Technical error will be thrown because there is no parametrized constructor with argument type integer


            //ConstructorPOC co = new ConstructorPOC("Ragini");
            //Console.WriteLine(co.i);
            ConstructorPOC co = new ConstructorPOC();
        }
    }
}
