using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.String_POC
{
    public class StringDeclarationAndInitialization
    {
        static void Main(string[] args)
        {
            //Declaring a string Name using "System.String" class
            System.String Name;
            //Initialization of String
            Name = "Rag";
            //Declaring a string id using an alias(shorthand) "String" of System.String class
            String id;
            //Initialization of String
            id = "1";
            //Declaring a string using string keyword
            string marks;
            //Initialization of String
            marks = "100";

            // Declaration and initialization of the string in a single line
            string rank = "1";

            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Marks: {0}", marks);
            Console.WriteLine("Rank: {0}", rank);
        }

    }
}
