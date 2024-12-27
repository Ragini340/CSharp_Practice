using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Encapsulation
{
    /*Automatic Properties(Short Hand):-
    C# also provides a way to use short-hand / automatic properties, where we do not have to define the field for the property, 
    and we only have to write get; and set; inside the property.*/
    public class EncapsulationUsingPublicProp
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public static void Main(string[] args)
        {
            EncapsulationUsingPublicProp encapsulations = new EncapsulationUsingPublicProp();
            encapsulations.Name = "Rag";
            encapsulations.Email = "test1@gmail.com";
            encapsulations.Id = 12;
            Console.WriteLine("Name: " + encapsulations.Name);
            Console.WriteLine("Email: " + encapsulations.Email);
            Console.WriteLine("Id: " + encapsulations.Id);
        }
    }
}
