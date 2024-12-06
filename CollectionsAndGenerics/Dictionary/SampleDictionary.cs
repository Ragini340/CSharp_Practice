using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.Dictionary
{
    public class SampleDictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> dic1 = new Dictionary<int, string>()
            {
                { 1, "a" }, { 2, "b" }, { 3, "c" }
            };

            Dictionary<string, int> dic2 = new Dictionary<string, int>();
            dic2.Add("abc", 11);
            dic2.Add("xyz", 12);
            dic2.Add("aaa", 13);
          //  dic2.Add("a");


            //Printing key and value
            foreach (KeyValuePair<int, string> element1 in dic1)
            {
                Console.WriteLine("HashCode is: " + element1.Key.GetHashCode());
                Console.WriteLine("{0}  {1}", element1.Key, element1.Value);
                Console.WriteLine("Index is: " + Math.Abs(element1.Key.GetHashCode() % 16));
            }

            Console.WriteLine();
            foreach (KeyValuePair<string, int> element2 in dic2)
            {
                Console.WriteLine("{0}  {1}", element2.Key, element2.Value);
            }
            Console.WriteLine();

            //Printing only key
            foreach (KeyValuePair<int, string> key1 in dic1)
            {
                Console.WriteLine(key1.Key);
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, int> key2 in dic2)
            {
                Console.WriteLine(key2.Key);
            }
            Console.WriteLine();

            //Printing only value
            foreach (KeyValuePair<int, string> value1 in dic1)
            {
                Console.WriteLine(value1.Value);
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, int> value2 in dic2)
            {
                Console.WriteLine(value2.Value);
            }
            Console.WriteLine();

            //Printing value using index
            Console.WriteLine("{0} {1} {2}", dic1[1], dic1[2], dic1[3]);
            Console.WriteLine();

            //Remove method
            dic1.Remove(2);
            foreach (KeyValuePair<int, string> removeElement in dic1)
            {
                Console.WriteLine("{0}  {1}", removeElement.Key, removeElement.Value);
            }
            Console.WriteLine();

            //Clear method
            dic2.Clear();
            Console.WriteLine(dic2.Count);
            Console.WriteLine();

            //ContainsKey method
            if (dic1.ContainsKey(1) == true)
            {
                Console.WriteLine("Key found");
            }
            else
            {
                Console.WriteLine("Key not found");
            }

            //ContainsValue method
            if (dic1.ContainsValue("b") == true)
            {
                Console.WriteLine("Value found");
            }
            else
            {
                Console.WriteLine("Value not found");
            }
        }

    }
}
