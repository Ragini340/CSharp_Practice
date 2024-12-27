using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Encapsulation
{
    public class EncapsulationUsingPrivateFields

    {
        //Below are private fields, so we need to write properties for these fileds like below commented code
        //https://www.w3schools.com/cs/cs_properties.php
        private string studentName;
        private int studentAge;

        /*Below are properties, directly we can write properties in the class.
        Automatic Properties(Short Hand):-
        C# also provides a way to use short-hand / automatic properties, where we do not have to define the field for the property, 
        and we only have to write get; and set; inside the property.
        /*public string Name { get; set; }   
        public int Age { get; set; }*/

        public string Name
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }

        public int Age
        {
            get
            {
                return studentAge;
            }
            set
            {
                studentAge = value;
            }
        }
        
        public static void Main(string[] args)
        {
            EncapsulationUsingPrivateFields encapsulationPOC = new EncapsulationUsingPrivateFields();
            encapsulationPOC.Name = "test";
            encapsulationPOC.Age = 5;
            Console.WriteLine("Name: " + encapsulationPOC.Name);
            Console.WriteLine("Age: " + encapsulationPOC.Age);
            Console.WriteLine();
        }
    }
}
