using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Lists
{
    //Program to find third smallest number in a list
    /*Time Complexity: O(N + N) = O(2N) = N 
      Space Complexity: O(1)
    */
    public class ThirdSmallestElementInList
    {
        public static void Main(string[] args)
        {
            List<int> lists = new List<int> { 5, 4, 3, 2, 2, 7, 7, 6, 7, 7, 7 };
            Console.WriteLine("Elements of list are: ");
            foreach (int list in lists)
            {
                Console.WriteLine(list);
            }
            Console.WriteLine();

            lists.Sort();
            Console.WriteLine("Sorted list's elements in ascending order are: ");
            for (int i = 0; i < lists.Count; i++)
            {
                int num = lists[i];
                Console.WriteLine(num);
            }
            Console.WriteLine();

            int index = 0;
            for (int i = 1; i < lists.Count; i++)
            {
                if (lists[0] != lists[i])
                {
                    int num = lists[i];
                    Console.WriteLine("Second smallest number is: " + num);
                    index = i;
                    Console.WriteLine("Index of second smallest number is: " + i);
                    break;
                }
            }
            Console.WriteLine();

            if (index != -1)
            {
                for (int i = index + 1; i <= lists.Count - 1; i++)
                {
                    if (lists[index] != lists[i])
                    {
                        int num2 = lists[i];
                        Console.WriteLine("Third smallest number is: " + num2);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("There is  no second and third smallest elements");
            }
        }
        
    }
}