using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.Dependency_Injection.Loose_Couple
{
    public class Television : IRemote
    {
        private static Television television;

        public void Run()
        {
            Console.WriteLine("Television started");
        }

        static Television()
        {
          television = new Television();
        }

        public static Television Instance
        {
            get
            {
                return television;
            }
        }
    }
}
