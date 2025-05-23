﻿namespace CSharp_Practice.CodingQuestions.Lists
{
    //Program to find third smallest number in a list
    /*Time Complexity: O(N + N) = O(2N) = N 
      Space Complexity: O(1)
    */
    public class ThirdSmallestElementInList
    {
        public static void ThirdSmallestElementOfList(List<int> lists)
        {
            lists.Sort();
            Console.WriteLine("\nSorted list's elements in ascending order are: ");
            for (int i = 0; i < lists.Count; i++)
            {
                int num = lists[i];
                Console.WriteLine(num);
            }

            int index = 0;
            for (int i = 1; i < lists.Count; i++)
            {
                if (lists[0] != lists[i])
                {
                    int num = lists[i];
                    Console.WriteLine("\nSecond smallest number is: " + num);
                    index = i;
                    Console.WriteLine("\nIndex of second smallest number is: " + i);
                    break;
                }
            }

            bool flag = false;
            int thirdSmallest = int.MaxValue;
            if (index != -1)
            {
                for (int i = index + 1; i <= lists.Count - 1; i++)
                {
                    if (lists[index] != lists[i])
                    {
                        thirdSmallest = lists[i];
                        flag = true;
                        break;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("\nThird smallest number is: " + thirdSmallest);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }

        public static void Main(string[] args)
        {
            List<int> lists = new List<int> { 5, 4, 3, 2, 2, 7, 7, 6, 7, 7, 7 };
            //Checking for negative scenario with below list:-
            // List<int> lists = new List<int> { 2, 2, 2 };
            Console.WriteLine("Elements of list are: ");
            foreach (int list in lists)
            {
                Console.WriteLine(list);
            }

            ThirdSmallestElementOfList(lists);
        }

    }
}