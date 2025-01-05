using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Delegate_POC
{
    public class Delegates
    {
        public void DoSomework(string message)
        {
            Console.WriteLine("DoSomework executed");
            Console.WriteLine($"Hello: {message}, Good Morning!!");
        }
    }
}
