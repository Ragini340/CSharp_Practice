using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.HashSet
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
            hashSet2.Add("Aa");
            hashSet2.Add("Bb");
            hashSet2.Add("Cc");
            hashSet2.Add("Dd");
            hashSet2.Add("Ee");
            hashSet2.Add("Ff");

            hashSet1.UnionWith(hashSet2);
            foreach (var item in hashSet1)
            {
                Console.WriteLine(item);
            }
        }

    }
}
