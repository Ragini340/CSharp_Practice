using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Lists
{
    //Program to find second largest number in a list
    /*Time Complexity: O(N + N) = O(2N) = N 
      Space Complexity: O(1)
    */
    public class SecondLargestElementInList
    {
        public static void Main(string[] args)
        {
            List<int> lists = new List<int> { 5, 3, 2, 6, 7, 7, 7 };
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

            Console.WriteLine("Size of the list is: " + lists.Count);
            Console.WriteLine();

            for (int i = lists.Count - 2; i >= 0; i--)
            {
                if (lists[i] != lists[lists.Count - 1])
                {
                    int num = lists[i];
                    Console.WriteLine("Second largest number is: " + num);
                    break;
                }
            } 
        }

    }
}