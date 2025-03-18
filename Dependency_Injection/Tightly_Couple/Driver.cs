using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Dependency_Injection.Tightly_Couple
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Remote remote = new Remote();
            remote.RunTelevision();
        }
    }
}
