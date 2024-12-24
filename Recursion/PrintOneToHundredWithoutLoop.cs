using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Recursion
{
    public class PrintOneToHundredWithoutLoop
    {
        public static void PrintNumbers(int num)
        {
            if (num <= 0)
            {
                return;
            }

            PrintNumbers(num - 1);
            Console.Write(num + " ");
        }

        public static void Main()
        {
            int num = 100;
            PrintNumbers(num);
        }
    }
}
