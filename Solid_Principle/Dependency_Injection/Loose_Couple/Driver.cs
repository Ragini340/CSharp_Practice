using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.Dependency_Injection.Loose_Couple
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Remote remote1 = new Remote(Television.Instance);
            remote1.Run();

            Remote remote2 = new Remote(Laptop.Instance);
            remote2.Run();

            Remote remote3= new Remote(Refrigerator.Instance);
            remote3.Run();
        }
    }
}
