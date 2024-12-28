using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Method_Overloading
{
    public class MethodOverloadingPOCDriver
    {
        public static void Main(string[] args)
        {
            MethodOverloadingPOCs methodOverloadingPOCs = new MethodOverloadingPOCs();
            MethodOverloadingPOCs obj = new MethodOverloadingPOCs(1, 2);
         
            int sum1 = methodOverloadingPOCs.Add(1,2);
            Console.WriteLine("Sum of the two integer value: " + sum1);
            int sum2 = methodOverloadingPOCs.Add(1,2,3);
            Console.WriteLine("Sum of the three integer value: " + sum2);

            int sum3 = methodOverloadingPOCs.Add(1);
            Console.WriteLine("sum is: " + sum3);
            double sum4 = methodOverloadingPOCs.Add(1.0);
            Console.WriteLine("sum is: " + sum4);

            methodOverloadingPOCs.Identity("Gabby", 1);
            methodOverloadingPOCs.Identity(2, "Bree");
        }
    }
}
