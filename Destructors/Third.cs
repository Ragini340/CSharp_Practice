using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Destructors
{
    public class Third : Second
    {
        ~Third  ()
        {
            Console.WriteLine("Destructor of Third Class");
        }

        public static void Main(string[] args)
        {
            Third obj = new Third();
            obj = null;
            GC.Collect();
        }
    }
}