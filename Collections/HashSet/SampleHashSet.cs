using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.HashSet
{
    public class SampleHashSet
    {
        public static void Main(string[] args)
        {
            HashSet<int> oddNumbers = new HashSet<int>();
            for (int i = 0; i < 10; i++)
            {
                oddNumbers.Add(2 * i + 1);
            }
            foreach (int odds in oddNumbers)
            {
                Console.WriteLine(odds);
            }
            Console.WriteLine();

            //Count property
            Console.WriteLine("Count of elements in the HashSet is: " + oddNumbers.Count);
            Console.WriteLine();

            //Contains method
            if (oddNumbers.Contains(3) == true)
            {
                Console.WriteLine("Element is found");
            }
            else
            {
                Console.WriteLine("Element is not found");
            }
            Console.WriteLine();

            //Clear method
            oddNumbers.Clear();
            Console.WriteLine("After using Clear method count of elements is: " + oddNumbers.Count);

        }
    }
}
