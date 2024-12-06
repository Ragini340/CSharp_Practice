using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.HashSet
{
    public class SetOperationsOfHashSet
    {
        public static void Main()
        {
            HashSet<int> set1 = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                set1.Add(i);
            }
            Console.WriteLine("Elements of set1 are:");
            foreach (int element in set1)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Elements of set2 are:");
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                set2.Add(i);
            }
            foreach (int elemnt in set2)
            {
                Console.WriteLine(elemnt);
            }

            //UnionWith
            HashSet<int> set3 = new HashSet<int>(set1);
            set3.UnionWith(set2);
            Console.WriteLine("Elements after Union of set1 and set2:");
            foreach (int element in set3)
            {
                Console.WriteLine(element);
            }

            //IntersectWith
            set3.IntersectWith(set2);
            Console.WriteLine("Elements after Intersection of set1 and set2:");
            foreach (int element in set3)
            {
                Console.WriteLine(element);
            }

            //ExceptWith
            HashSet<string> hashSet1 = new HashSet<string>();
            hashSet1.Add("A");
            hashSet1.Add("B");
            hashSet1.Add("C");
            hashSet1.Add("D");
            hashSet1.Add("E");
            hashSet1.Add("F");

            HashSet<string> hashSet2 = new HashSet<string>();
            hashSet2.Add("A");
            hashSet2.Add("Bb");
            hashSet2.Add("Cc");
            hashSet2.Add("Dd");
            hashSet2.Add("Ee");
            hashSet2.Add("F");

            hashSet1.ExceptWith(hashSet2);
            Console.WriteLine("Elements after using ExceptWith Operator on hashSet1 and hashSet2:");
            foreach (var element in hashSet1)
            {
                Console.WriteLine(element);
            }

        }

    }
}
