using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Destructors
{
    public class Second : First
    {
        ~Second()
        {
            Console.WriteLine("Destructor of Second Class");
        }
    }
}
