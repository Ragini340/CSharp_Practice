using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions
{
    public class FibonacciSeries
    {
        public static int Fibonacci(int num)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < num; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}
