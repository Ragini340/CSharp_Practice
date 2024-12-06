using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CollectionsAndGenerics.Dictionary.SortedDictionary
{
    public class SampleSortedDictionary
    {
        public static void Main()
        {
            SortedDictionary<int, string> dic1 = new SortedDictionary<int, string>()
            {
                { 10, "Ten" },{ 5, "Five" },{ 6, "Six" }
            };
            Console.WriteLine("Elements of dic1: ");
            foreach (KeyValuePair<int, string> kvp in dic1)
            {
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }

            SortedDictionary<int, string> dic2 = new SortedDictionary<int, string>();
            dic2.Add(5, "ab");
            dic2.Add(3, "bc");
            dic2.Add(2, "cd");
            Console.WriteLine("Elements of dic2: ");
            foreach (KeyValuePair<int, string> kvp in dic2)
            {
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }

            //Clear method
            dic2.Clear();
            Console.WriteLine("After using Clear method element's count of dic2: " + dic2.Count);

            //Remove method
            dic1.Remove(10);
            Console.WriteLine("Elements of dic1 after removing key 10: ");
            foreach (KeyValuePair<int, string> kvp in dic1)
            {
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }

            //ContainsKey method
            if (dic1.ContainsKey(5) == true)
            {
                Console.WriteLine("Element found");
            }
            else
            {
                Console.WriteLine("Element not found");
            }

            //ContainsValue method
            if (dic1.ContainsValue("Five") == true)
            {
                Console.WriteLine("Element found");
            }
            else
            {
                Console.WriteLine("Element not found");
            }

            //TryGetValue method
            string value;
            if (dic1.TryGetValue(5, out value))
            {
                Console.WriteLine("Value at key 5 of dic1 is: " + value);
            }
            else
            {
                Console.WriteLine("Value at key 5 not found");
            }

        }
    }
}
