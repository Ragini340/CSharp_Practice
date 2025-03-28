namespace CSharp_Practice.CodingQuestions.Lists
{
    //Program to find third largest number in a list
    /*Time Complexity: O(N + N) = O(2N) = N 
      Space Complexity: O(1)
     */
    public class ThirdLargestElementInList
    {
        public static void ThirdLargestElementOfList(List<int> lists)
        {
            lists.Sort();
            Console.WriteLine("\nSorted list's elements in ascending order are: ");
            for (int i = 0; i < lists.Count; i++)
            {
                int num = lists[i];
                Console.WriteLine(num);
            }

            Console.WriteLine("\nSize of the list is: " + lists.Count);
    
            int index = 0;
            for (int i = lists.Count - 2; i >= 0; i--)
            {
                if (lists[i] != lists[lists.Count - 1])
                {
                    int num = lists[i];
                    Console.WriteLine("\nSecond largest number is: " + num);
                    index = i;
                    Console.WriteLine("\nIndex of second largest element is: " + i);
                    break;
                }
            }
         
            bool flag = false;
            int thirdLargest = int.MinValue;
            if (index != -1)
            {
                for (int i = index - 1; i >= 0; i--)
                {
                    if (lists[index] != lists[i])
                    {
                        thirdLargest = lists[i];
                        flag = true;
                        break;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("\nThird largest number is: " + thirdLargest);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }

        public static void Main(string[] args)
        {
            List<int> lists = new List<int> { 7, 2, 3, 7, 6, 5, 5, 7, 8 };
            //Checking for negative scenario with below list:-
            //List<int> lists = new List<int> { 7, 7, 7 };
            Console.WriteLine("Elements of list are: ");
            foreach (int list in lists)
            {
                Console.WriteLine(list);
            }
   
            ThirdLargestElementOfList(lists);
        }

    }
}