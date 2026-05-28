using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.LINQ.OrderBy_Methods
{
    public class NumberSorter
    {
        public static void SortNumbers(int[] nums)
        {
            var sorted = nums.OrderBy(x => x);

            Console.WriteLine("Sorted Numbers:");

            foreach (var num in sorted)
            {
                Console.WriteLine(num);
            }
        }

        public static void Main(string[] args)
        {
            int[] nums = { 5, 2, 8, 1, 4 };

            SortNumbers(nums);
        }
    }
}