using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Singleton_Design_Pattern
{
    //Using Thread safe
    public class Singleton3
    {
        private static Singleton3 obj = null;
        private static readonly object padlock = new object();

        private Singleton3()
        {

        }

        public static Singleton3 GetInstance()
        {
            lock(padlock)
            {
                if(obj == null )
                {
                    obj = new Singleton3();
                }
                return obj;
            }
        }

        public static void Main()
        {
            Singleton3 obj1 = Singleton3.GetInstance();
            Console.WriteLine(obj1.GetHashCode());
            //Hashcode of obj1 = obj2
            Singleton3 obj2 = Singleton3.GetInstance();
            Console.WriteLine(obj2.GetHashCode());
        }

    }
}
