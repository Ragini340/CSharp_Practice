using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.LINQ.OrderByDescending_Methods
{
    /*Find the second highest number using LINQ.*/
    public class DisplaySecondHighest
    {
        public static void DisplaySecondHighestNum()
        {
            List<int> numbers = new List<int>
            {
            10, 20, 50, 40, 50, 30
            };

            int secondHighest = numbers
                .Distinct()
                .OrderByDescending(n => n)
                .Skip(1)
                .First();

            Console.WriteLine($"Second Highest: {secondHighest}");
        }

        public static void Main(string[] args)
        {
            DisplaySecondHighestNum();
        }

    }
}