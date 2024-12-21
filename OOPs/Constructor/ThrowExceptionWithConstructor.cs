using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Constructor
{
    //We can throw an exception from the constructor as:
    public class ThrowExceptionWithConstructor
    {
        int result;
        public ThrowExceptionWithConstructor()
        {
            int a = 0, b = 1;
            if (a == 0)
            {
                throw new Exception("Division by zero exception.Ragini");
            }
            result = b / a;
        }
        public static void Main(string[] args)
        {
            ThrowExceptionWithConstructor throwExceptionWithConstructor = new ThrowExceptionWithConstructor();
            Console.WriteLine(throwExceptionWithConstructor.result);
        }
    }
}
