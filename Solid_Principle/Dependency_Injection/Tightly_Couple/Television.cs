using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.Dependency_Injection.Tightly_Couple
{
    public class Television
    {
        private static Television television;

        static Television()  
        {
            television = new Television(); //Creating object of Television in static constructor
        }
        
        public static Television Instance
        {
            get
            {
                return television;
            }
        }

        public void Run()
        {
            Console.WriteLine("Television started");
        }
    }
}
