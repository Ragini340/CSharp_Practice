using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC.Strings
{
    public class EqualityOperatorAndEqualsMethod
    {
        public static void Main(string[] args)
        {
            string name = "Ragini";
            string myName = name;
            Console.WriteLine("== operator result is: {0}", name == myName);  //== is doing address comparision
            Console.WriteLine("Equals method result is: {0}", name.Equals(myName)); //Equals() method is comparing the contents of a string
            Console.WriteLine();

            object name1 = "Rag";
            char[] values = { 'R', 'a', 'g' };
            object myName1 = new String(values);
            Console.WriteLine("== operator result is: {0}", name1 == myName1); //Here == Operator will return False because it compares
                                                                               //the reference identity 
            Console.WriteLine("Equals method result is: {0}", name1.Equals(myName1));
            Console.WriteLine();

            /*Equals() method is an extension method of the string class, when we assign a null value to the string variable and using 
             * that variable the Equals() method then gets an exception of a null reference, so we must be sure that our variable 
             * doesn’t have null values when calling the Equals() method. When our one variable contains a null value then we should
             * use that variable as an argument for the Equals() method.*/
            name = "Ra";
            myName = null;
            Console.WriteLine("== operator result is: {0}", name == myName);
            Console.WriteLine("Equals method result is: {0}", myName.Equals(name));
        }
    }
}
