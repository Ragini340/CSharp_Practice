using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Constructor
{
    public class StaticConstructorDriver
    {
        public static void Main(string[] args)
        {
            StaticConstructor staticConstructor = new StaticConstructor();
            Console.WriteLine("Main method execution has been started");
            Console.WriteLine(staticConstructor.i);
            Console.WriteLine(StaticConstructor.j);
        }
    }
}
