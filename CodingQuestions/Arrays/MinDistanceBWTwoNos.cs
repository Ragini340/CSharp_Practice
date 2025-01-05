using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.Arrays
{
    /* Find the minimum distance between two numbers
     * Time Complexity: O(n), Only one traversal of the array is required.
       Space Complexity: O(1), No extra space is required.
     */
    public class MinDistanceBWTwoNos
    {
        public static int MinDistance(int[] arr, int n, int x, int y)
        {
            int idx_x = -1;
            int idx_y = -1;
            int min_dist = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    idx_x = i;
                }
                else if (arr[i] == y)
                {
                    idx_y = i;
                }
                if (idx_x != -1 && idx_y != -1)
                {
                    min_dist = Math.Min(min_dist, Math.Abs(idx_x - idx_y));
                }
            }

            if (idx_x == -1 || idx_y == -1)
            {
                return -1;
            }
            else
            {
                return min_dist;
            }
        }

        public static void Main()
        {
            int[] arr = { 3, 5, 4, 6, 6, 3 };
            int n = arr.Length;
            int x = 3;
            int y = 6;
            Console.WriteLine("Minimum distance b/w x and y is:-");
            Console.WriteLine(MinDistance(arr, n, x, y));
        }
    }

}