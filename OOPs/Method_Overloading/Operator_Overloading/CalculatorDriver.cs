using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Method_Overloading.Operator_Overloading
{
    public class CalculatorDriver
    {
        public static void Main(string[] args)
        {
            Calculator cal = new Calculator(10, -20);
            cal = -cal;  //If here it is minus then we required - in operator overloading method, So basically this step is for operator overloading.
            cal.Print();

            int a = 10;
            int b = 20;
            int result = a + b;  // Both operand is premitive data type, so it is not goining to call + opeartor overloading method.
            Console.WriteLine(result);
        }
    }
}
