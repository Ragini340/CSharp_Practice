using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.Dependency_Injection.Loose_Couple
{
    public class Laptop : IRemote
    {
        private static Laptop laptop;

        public void Run()
        {
            Console.WriteLine("Laptop started");
        }

        static Laptop()
        {
            laptop = new Laptop();
        }

        public static Laptop Instance
        {
            get
            {
                return laptop;
            }
        }
    }
}
