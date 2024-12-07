using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Singleton_Design_Pattern
{
    //Eager Initialization
    public class Singleton2
    {
        private static Singleton2 singleton2 = new Singleton2();
        private Singleton2()
        {
        }

        public static Singleton2 GetInstance()
        {
            return singleton2;
        }

        public static void Main()
        {
            Singleton2 obj1 = Singleton2.GetInstance();
            Console.WriteLine(obj1.GetHashCode());
            //Hashcode of obj1 = obj2
            Singleton2 obj2 = Singleton2.GetInstance();
            Console.WriteLine(obj2.GetHashCode());
        }
    }
}
