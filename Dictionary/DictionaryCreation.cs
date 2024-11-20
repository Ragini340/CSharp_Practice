using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPs_Practice.Dictionary
{
    public class DictionaryCreation
    {
        public static void Main()
        {
            Dictionary<int, string> dic1 = new Dictionary<int, string>();
            dic1.Add(1, "a");
            dic1.Add(2, "b");
            dic1.Add(3, "c");

            foreach (KeyValuePair<int, string> element1 in dic1)
            {
                Console.WriteLine("Key: {0} -> Value: {1}", element1.Key, element1.Value);
            }
            Console.WriteLine();

            Dictionary<string, string> dic2 = new Dictionary<string, string>
            {
                { "aa", "bb" }, { "cc", "dd" }, { "ee", "ff" }
            };

            foreach (KeyValuePair<string, string> element2 in dic2)
            {
                Console.WriteLine("Key: {0} -> Value: {1}", element2.Key, element2.Value);
            }
        }

    }
}
