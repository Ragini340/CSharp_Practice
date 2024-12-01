using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.HashSet
{
    public class HashSetClearMethod
    {
        public static void Main(String[] args)
        {
            HashSet<string> hashSet1 = new HashSet<string>();
            hashSet1.Add("A");
            hashSet1.Add("B");
            hashSet1.Add("C");
            hashSet1.Add("D");
            hashSet1.Add("E");
            hashSet1.Add("F");

            hashSet1.Clear();
            Console.WriteLine("Total number of elements present in hashset1 are :{0}", hashSet1.Count);
        }

    }
}
