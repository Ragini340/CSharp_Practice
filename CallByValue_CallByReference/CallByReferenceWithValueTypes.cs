using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CallByValue_CallByReference
{
    public class CallByReferenceWithValueTypes
    {
        public static void Main(string[] args)
        {
            int a = 15;
            UpdateValue(ref a);
            Console.WriteLine(a);
        }

        public static void UpdateValue(ref int b)
        {
            b = 30;
        }
    }
}