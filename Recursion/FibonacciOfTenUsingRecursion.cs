using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Recursion
{
    public class FibonacciOfTenUsingRecursion
    {
        public static int FindFibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return FindFibonacci(n - 1) + FindFibonacci(n - 2);
        }

        public static void Main(string[] args)
        {
            int n = 10;
            int fibonacci = FindFibonacci(n);
            Console.WriteLine(fibonacci);
        }
    }
}