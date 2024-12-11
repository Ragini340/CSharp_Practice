using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Delegate
{
    public class DelegatePOC
    {
        public delegate void Addnumbers(int x, int y);
        public delegate void Subtractumbers(int x, int y);

        public void Sum(int x, int y)
        {
            Console.WriteLine("100 + 200 = {0} ", x + y);
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine("200 - 100 = {0} ", x - y);
        }

        public static void Main(string[] args)
        {
            DelegatePOC delegatePOC = new DelegatePOC();
            Addnumbers delegate1 = new Addnumbers(delegatePOC.Sum);
            Subtractumbers delegate2 = new Subtractumbers(delegatePOC.Subtract);

            //Passing the values to the methods by delegate object
            delegate1(100, 200);
            delegate2(200, 100);

            //Or we can write using Invoke method
            delegate1.Invoke(100, 200);
            delegate2.Invoke(200, 100);
        }

    }
}
