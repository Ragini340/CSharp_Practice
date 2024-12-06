using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CollectionsAndGenerics.SortedSets
{
    public class SampleSortedSets
    {
        public static void Main()
        {
            SortedSet<int> sortedSet1 = new SortedSet<int>
            {
                { 10 }, { 15 }, { 20 }
            };
            Console.WriteLine("Elements in sortedSet1 are:");
            foreach (int set in sortedSet1)
            {
                Console.WriteLine(set);
            }

            SortedSet<string> sortedSet2 = new SortedSet<string>();
            sortedSet2.Add("abc");
            sortedSet2.Add("xyd");
            sortedSet2.Add("qav");
            Console.WriteLine("Elements in sortedSet2 are:");
            foreach (string value in sortedSet2)
            {
                Console.WriteLine(value);
            }

            //Remove method
            sortedSet1.Remove(15);
            Console.WriteLine("Remaining elements in sortedSet1 after removing element 15:");
            foreach (int set in sortedSet1)
            {
                Console.WriteLine(set);
            }

            //Contains method
            if (sortedSet1.Contains(10) == true)
            {
                Console.WriteLine("Element is found");
            }
            else
            {
                Console.WriteLine("Element is not found");
            }

            //Clear Method
            sortedSet2.Clear();
            Console.WriteLine("Count of elements in sortedSet2 after using Clear method: " + sortedSet2.Count);

            SortedSet<int> sortedSet3 = new SortedSet<int>();
            for (int i = 0; i < 10; i++)
            {
                sortedSet3.Add(i);
            }
            Console.WriteLine("Elements of sortedSet3:");
            foreach (int set in sortedSet3)
            {
                Console.WriteLine(set);
            }

            //RemoveWhere method
            sortedSet3.RemoveWhere(isEven);
            Console.WriteLine("Elements of sortedSet3 after using RemoveWhere method:");
            foreach (int set in sortedSet3)
            {
                Console.WriteLine(set);
            }
        }

        private static bool isEven(int value)
        {
            return value % 2 == 0;
        }

    }
}