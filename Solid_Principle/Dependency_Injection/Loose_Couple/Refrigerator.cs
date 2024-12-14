using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.Dependency_Injection.Loose_Couple
{
    public class Refrigerator : IRemote
    {
        private static Refrigerator refrigerator;

        public void Run()
        {
            Console.WriteLine("Refrigerator started");
        }
      
        static Refrigerator()
        {
            refrigerator = new Refrigerator();
        }

        public static Refrigerator Instance
        {
            get
            {
                return refrigerator;
            }
        }
    }
}
