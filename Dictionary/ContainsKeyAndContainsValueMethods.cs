using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPs_Practice.Dictionary
{
    public class ContainsKeyAndContainsValueMethods
    {
        static public void Main()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(11, "aa");
            dic.Add(111, "bb");
            dic.Add(1111, "cc");

            if (dic.ContainsKey(11) == true)
            {
                Console.WriteLine("Key is found");
            }
            else
            {
                Console.WriteLine("Key is not found");
            }

            if (dic.ContainsValue("aa") == true)
            {
                Console.WriteLine("Value is found");
            }
            else
            {
                Console.WriteLine("Value is not found");
            }
        }

    }
}
