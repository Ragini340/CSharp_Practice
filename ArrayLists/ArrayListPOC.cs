using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.OOPs.Constructor;

namespace CSharp_Practice.ArrayLists
{
    //ArrayList: IList, ICloneable
    public class ArrayListPOC
    {
        public ArrayListPOC() { }
        public ArrayListPOC(ICollection c)
        {
        }
        public ArrayListPOC(int capacity)
        {
        }

        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList(5);
            Console.WriteLine("Capacity is: " + arrayList.Capacity);
            Console.WriteLine("Count is: " + arrayList.Count);

            ArrayList arrayList1 = new ArrayList();
            Console.WriteLine("Capacity is: " + arrayList1.Capacity);
            Console.WriteLine("Count is: " + arrayList1.Count);

            arrayList1.Add(100);
            arrayList1.Add("Ragini");
            arrayList1.Add("Ragini");
            arrayList1.Add(" ");
            arrayList1.Add(true);
            arrayList1.Add(4.02);
            arrayList1.Add(null);
            Console.WriteLine("ArrayList1 elements are:-");
            foreach (var item in arrayList1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Accessing list elements using index
            int firstElement = (int)arrayList1[0];
            string secondElement = (string)arrayList1[1];
            string thirdElement = (string)arrayList1[2];
            Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}, Third Element: {thirdElement} ");

            //Accessing list elements using var keyword without explicit casting
            var firsItem = arrayList1[0];
            var secondItem = arrayList1[1];
            Console.WriteLine($"First Item: {firsItem}, Second Item: {secondItem}");

            var arrayList2 = new ArrayList()
            {
                101,
                "Singh",
                "Singh",
                false,
                10.6
            };
            Console.WriteLine("ArrayList2 elements are:-");
            foreach (var item in arrayList2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Updating elements of arrayList2
            arrayList2[0] = "Bree";
            arrayList2[1] = 1000;
            Console.WriteLine("Updated ArrayList2 elements are:-");
            foreach (var item in arrayList2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}