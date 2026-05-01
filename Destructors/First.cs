using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Destructors
{
    public class First
    {
        ~First()
        {
            Console.WriteLine("Destructor of First Class");
        }
    }
}