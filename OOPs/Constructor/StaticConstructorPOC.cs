using System;

namespace CSharp_Practice.OOPs.Constructor
{
    public class StaticConstructorPOC
    {
        // Static field shared across all instances of the class
        static int id;

        /*
         * Static Constructor:
         * - Executes automatically only once per class
         * - Called before the first instance is created or any static member is accessed
         * - Used to initialize static data
         */
        static StaticConstructorPOC()
        {
            id = 119;
            Console.WriteLine("Static Constructor: Value of id = " + id);
        }

        /*
         * Instance (Non-Static) Constructor:
         * - Executes every time an object is created
         * - Used to initialize instance-specific data
         */
        public StaticConstructorPOC()
        {
            string name = "Ragini";
            Console.WriteLine("Instance Constructor: Name = " + name);
        }

        public static void Main(string[] args)
        {
            /*
             * Execution Flow:
             * 1. Static constructor is called automatically (only once)
             * 2. Instance constructor is called when object is created
             */

            StaticConstructorPOC obj = new StaticConstructorPOC();
        }
    }
}