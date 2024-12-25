using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Cloning.Array_Cloning
{
    public class SampleArrayCloning
    {
        public static void Main(string[] args)
        {
            string[] originalArray = { "This", "is", "CSharp", "Programming" };
            string[] clonedArray = (string[])originalArray.Clone();

            Console.WriteLine(string.Join(", ", originalArray));
            Console.WriteLine(string.Join(", ", clonedArray));
        }
    }
}
