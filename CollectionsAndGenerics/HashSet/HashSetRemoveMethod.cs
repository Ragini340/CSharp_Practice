using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.HashSet
{
    public class HashSetRemoveMethod
    {
        public static void Main(string[] args)
        {
            HashSet<string> hashSet1 = new HashSet<string>();
            hashSet1.Add("A");
            hashSet1.Add("B");
            hashSet1.Add("C");
            hashSet1.Add("D");
            hashSet1.Add("E");
            hashSet1.Add("F");

            hashSet1.Remove("F");
            Console.WriteLine("Elements of hashset1 after removal are: ");
            foreach (var item in hashSet1)
            {
                Console.WriteLine(item);
            }
        }

    }
}
