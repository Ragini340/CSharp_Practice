using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Singleton_Design_Pattern
{
    //Using double check locking
    public class Singleton4
    {
        private static Singleton4 obj = null;
        private static readonly object padlock = new object();

        private Singleton4()
        {
        }

        public static Singleton4 GetInstance()
        {
            if (obj == null)
            {
                lock (padlock)
                {
                    if (obj == null)
                    {
                        obj = new Singleton4();
                    }
                    return obj;
                }
            }
            return obj;
        }

        public static void Main()
        {
            Singleton4 obj1 = Singleton4.GetInstance();
            Console.WriteLine(obj1.GetHashCode());
            //Hashcode of obj1 = obj2
            Singleton4 obj2 = Singleton4.GetInstance();
            Console.WriteLine(obj2.GetHashCode());
        }

    }
}