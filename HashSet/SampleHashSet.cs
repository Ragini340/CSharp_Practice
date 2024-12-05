using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.HashSet
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
        }
    }
}
