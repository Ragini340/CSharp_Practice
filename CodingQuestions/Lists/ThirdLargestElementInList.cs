using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Lists
{
    //Program to find third largest number in a list
    /*Time Complexity: O(N + N) = O(2N) = N 
      Space Complexity: O(1)
     */
    public class ThirdLargestElementInList
    {
        public static void Main(string[] args)
        {
            List<int> lists = new List<int> { 7, 2, 3, 7, 6, 5, 5, 7, 8 };
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

            int index = 0;
            for (int i = lists.Count - 2; i >= 0; i--)
            {
                if (lists[i] != lists[lists.Count - 1])
                {
                    int num = lists[i];
                    Console.WriteLine("Second largest number is: " + num);
                    index = i;
                    Console.WriteLine("Index of second largest element is: " + i);
                    break;
                }
            }
            Console.WriteLine();

            if (index != -1)
            {
                for (int i = index - 1; i >= 0; i--)
                {
                    if (lists[index] != lists[i])
                    {
                        int num2 = lists[i];
                        Console.WriteLine("Third largest number is: " + num2);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("There is  no second and third largest elements");
            }

        }
    }
}
