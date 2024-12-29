using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CollectionsAndGenerics.Generics
{
    public class GenericsClassDriver
    {
        public static void Main(string[] args)
        {
            GenericsClass<int> genericsClass = new GenericsClass<int>(100); //Generic constructor
            int val = genericsClass.GenericMethod(200); //Generic method
            Console.WriteLine(val); //Generic member variable
            genericsClass.GenericProperty = 50; //Generic property
            Console.WriteLine("Generic Property is: " + genericsClass.GenericProperty);
            Console.WriteLine();

            GenericsClass<string> genericsClassString = new GenericsClass<string>("Ragini"); //Generic constructor
            string value = genericsClassString.GenericMethod("Singh"); //Generic method
            Console.WriteLine(value); //Generic member variable
            genericsClassString.GenericProperty = "Prop"; //Generic property
            Console.WriteLine("Generic Property is: " + genericsClassString.GenericProperty);
        }
    }
}
