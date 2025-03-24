using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Cloning.Array_Cloning
{
    public class ArrayDeepCopy
    {
        public static void Main(string[] args)
        {
            string[] originalArray = { "This", "is", "CSharp", "Programming" };
            string[] clonedArray = (string[])originalArray.Clone();
            Console.WriteLine(string.Join(", ", originalArray));
            Console.WriteLine(string.Join(", ", clonedArray));
            Console.WriteLine("Original array hascode: " + originalArray.GetHashCode());
            Console.WriteLine("Cloned array hascode: " + clonedArray.GetHashCode());
            Console.WriteLine("Hashcode at index 3 for original array: " +originalArray[3].GetHashCode());
            Console.WriteLine("Hashcode at index 3 for cloned array: " +clonedArray[3].GetHashCode());

            clonedArray[3] = "demo";
            Console.WriteLine("Aftre changing value at index 3 hashcode of index 3 is: " +clonedArray[3].GetHashCode());
            Console.WriteLine(string.Join(", ", originalArray));
            Console.WriteLine(string.Join(", ", clonedArray));
            Console.WriteLine("Now cloned array hashcode: " + clonedArray.GetHashCode());

            //So we can conclude that Clone() method is doing deep copy i.e if we are doing any changes in copied object
            //and not changing original object and vice versa.

            //Now we are changing original object after cloning, so it should not do any changes in cloned object.
            originalArray[0] = "Ragini";
            Console.WriteLine("After changes in original object: ");
            Console.WriteLine("Original array: " + string.Join(", ", originalArray));
            Console.WriteLine("Cloned array: "+ string.Join(", ", clonedArray));
        }

    }
}
