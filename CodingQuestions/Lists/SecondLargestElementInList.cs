namespace CSharp_Practice.CodingQuestions.Lists
{
    //Program to find second largest number in a list
    /*Time Complexity: O(N + N) = O(2N) = N 
      Space Complexity: O(1)
    */
    public class SecondLargestElementInList
    {
        public static void SecondLargestElementOfList(List<int> lists)
        {
            lists.Sort();
            Console.WriteLine("\nSorted list's elements in ascending order are: ");
            for (int i = 0; i < lists.Count; i++)
            {
                int num = lists[i];
                Console.WriteLine(num);
            }
   
            Console.WriteLine("\nSize of the list is: " + lists.Count);
        
            bool flag = false;
            int secondLargest = int.MinValue;
            for (int i = lists.Count - 2; i >= 0; i--)
            {
                if (lists[i] != lists[lists.Count - 1])
                {
                    secondLargest = lists[i];
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("\nSecond largest number is: " + secondLargest);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }

        public static void Main(string[] args)
        {
            List<int> lists = new List<int> { 5, 3, 2, 6, 7, 7, 7 };
            //Checking for negative scenario with below list:-
            // List<int> lists = new List<int> { 7, 7, 7 };
            Console.WriteLine("Elements of list are: ");
            foreach (int list in lists)
            {
                Console.WriteLine(list);
            }
         
            SecondLargestElementOfList(lists);
        }

    }
}