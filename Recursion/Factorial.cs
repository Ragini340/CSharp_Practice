using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Recursion
{
    public class Factorial
    {
        int n = 1;
        public int FindFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return FindFactorial(n - 1) * n;
        }
    }

    public class FactorialDriver
    {
        public static void Main(string[] args)
        {
            int n = 5;
            Factorial factorial = new Factorial();
            int fact = factorial.FindFactorial(n);
            Console.WriteLine(fact);
        }
    }
}
