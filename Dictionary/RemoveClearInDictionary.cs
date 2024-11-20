using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    public class RemoveClearInDictionary
    {
        static public void Main()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Ab");
            dic.Add(11, "Cd");
            dic.Add(111, "Ef");

            foreach (KeyValuePair<int, string> element in dic)
            {
                Console.WriteLine("Key: {0} and Value: {1}", element.Key, element.Value);
            }
            Console.WriteLine();
            dic.Remove(1);

            foreach (KeyValuePair<int, string> element in dic)
            {
                Console.WriteLine("Key: {0} and Value: {1}", element.Key, element.Value);
            }
            Console.WriteLine();
            dic.Clear();

            Console.WriteLine("Total number of key/value " + "pairs present in dic: {0}", dic.Count);
        }

    }
}
