using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Recursion
{
    public class SumOfNumbers
    {
        int n = 1;
        public int FindSum(int n) 
        {
            if(n == 1)
            {
                return 1;
            }
          
            return FindSum(n - 1) + n;
        }
    }

    public class SumOfNumbersDriver
    {
        public static void Main()
        {
            int n = 10;
            SumOfNumbers sumOfNumbers = new SumOfNumbers();
            int sum = sumOfNumbers.FindSum(n);
            Console.WriteLine(sum);
        }
    }

}
