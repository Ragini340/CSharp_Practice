using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CollectionsAndGenerics.List
{
    public class SampleList
    {
        public static void Main()
        {
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
           
            Console.WriteLine("Elements of lists are:");
            foreach(int list in list1)
            {
                Console.WriteLine(list);
            }

            //AddRange method
            list1.AddRange(list1);
            Console.WriteLine("Elements of lists after using AddRange method are:");
            foreach (int list in list1)
            {
                Console.WriteLine(list);
            }
        }
    }
}
