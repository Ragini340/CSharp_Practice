using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Collections.Generic.List
{
    public class ListPOC
    {
        public static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("Gaby");
            list1.Add("Bree");

            List<string> list2 = new List<string>();
            list2.Add("100");
            list2.Add("101");

            //AddRange
            list1.AddRange(list2);
            Console.WriteLine("list1 data:-");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
          
            //Creating a list collection using collection initializer 
            List<string> list3 = new List<string>
            {
                "Zach",
                "Juli",
            };

            //Accessing list elements using for loop
            Console.WriteLine("\nAccessing list3 using for loop:-");
            for (int i = 0; i < list3.Count; i++)
            {
                var element = list3[i];
                Console.WriteLine(element);
            }
      
            //Accessing list elements by using the index 
            Console.WriteLine("\nAccessing list3 elements by index position");
            Console.WriteLine($"First element:- {list3[0]}");
            Console.WriteLine($"Second element:- {list3[1]}");

            //Insert
            list3.Insert(1, "Mike"); //Inserting "Mike" at index 1, so "Juli" will be shifted to index 2
            Console.WriteLine("\nAccessing list3 after inserting Mike at index 1");
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

            //InsertRange
            list3.InsertRange(0, list1);
            Console.WriteLine("\nAccessing list3 after InsertRange at index 0:-");
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCount of list3 is: " + list3.Count); //Count is 7
            //list3.Insert(8, "Ragini"); //Unhandled exception. System.ArgumentOutOfRangeException: Index must be within
                                         //the bounds of the List. (Parameter 'index')
            //list3.InsertRange(8, list2);  //Unhandled exception. System.ArgumentOutOfRangeException: Index was out of
                                           //range. Must be non-negative and less than the size of the collection. (Parameter 'index')
           
        }
    }
}
