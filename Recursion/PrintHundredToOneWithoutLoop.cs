using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Recursion
{
    public class PrintHundredToOneWithoutLoop
    {
        public static void PrintNumbers(int num)
        {
            if (num <= 0)
            {
                return;
            }
            Console.Write(num + " ");
            PrintNumbers(num - 1);
        }

        public static void Main()
        {
            int num = 100;
            PrintNumbers(num);
        }
    }

}