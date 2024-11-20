using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPs_Practice.ArrayLists
{
    public class ArrayListCreation
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Rag");
            arrayList.Add("Sin");

            Console.WriteLine("Count of the ArrayList: " + arrayList.Count);
            Console.WriteLine("Capacity of the ArrayList: " + arrayList.Capacity);

            //Accessing the elements
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }

        }
    }

}
