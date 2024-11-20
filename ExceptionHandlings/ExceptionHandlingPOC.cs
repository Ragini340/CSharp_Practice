using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Practice.ExceptionHandlings
{
    public class ExceptionHandlingPOC
    {
        static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(arr[7]);
        }

    }
}
