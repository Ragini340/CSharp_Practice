using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.HashSet
{
    public class HashSetCreation
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
            Console.WriteLine("Elements of Hashset1 are: ");

            foreach (var item in hashSet1)
            {
                Console.WriteLine(item);
            }

            HashSet<int> hashSet2 = new HashSet<int>()
            {
              10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
            Console.WriteLine("Elements of Hashset2 are: ");

            foreach (var item in hashSet2)
            {
                Console.WriteLine(item);
            }
        }

    }
}
