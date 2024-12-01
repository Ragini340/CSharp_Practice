using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.HashSet
{
    public class HashSetUnionWithMethod
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

            HashSet<string> hashSet2 = new HashSet<string>();
            hashSet1.Add("Aa");
            hashSet1.Add("Bb");
            hashSet1.Add("Cc");
            hashSet1.Add("Dd");
            hashSet1.Add("Ee");
            hashSet1.Add("Ff");

            hashSet1.UnionWith(hashSet2);
            foreach (var item in hashSet1)
            {
                Console.WriteLine(item);
            }
        }

    }
}
