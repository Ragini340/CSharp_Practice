using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Destructors
{
    public class DestructorDriverClass
    {
        public static void Main()
        {
            DestructorEx destructorEx = new DestructorEx();
            destructorEx.SetValues(2, 3);
            destructorEx.DisplayValue();
        }
    }
}
