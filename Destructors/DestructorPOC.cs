using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Destructors
{
    public class DestructorPOC
    {
        public DestructorPOC()
        {
            Console.WriteLine("Constructor is called");
        }

        ~DestructorPOC()
        {
            string type = GetType().Name;
            Console.WriteLine($"Object {type} is Destroyed");
        }

        public static void Main(string[] args)
        {
            DestructorPOC destructorPOC = new DestructorPOC();
            DestructorPOC destructorPOC1 = new DestructorPOC();
            destructorPOC = null;
            destructorPOC1 = null;
            GC.Collect();
        }
    }
}