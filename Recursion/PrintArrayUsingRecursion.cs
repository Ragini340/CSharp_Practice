using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CSharp_Practice.Recursion
{
    public class PrintArrayUsingRecursion
    {
        int k = 0;
        public void PrintArrayElements(int[] arr, int k)
        {
            if (arr.Length - 1 == k)
            {
                Console.WriteLine(arr[k]);
                return;
            }
            Console.WriteLine(arr[k]);
            PrintArrayElements(arr, k + 1);
        }
    }

    public class Driver
    {
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            PrintArrayUsingRecursion printArrayUsingRecursion = new PrintArrayUsingRecursion();
            printArrayUsingRecursion.PrintArrayElements(arr, 0);
        }
    }

}
