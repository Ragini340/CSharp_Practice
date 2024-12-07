using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Singleton_Design_Pattern
{
    //Lazy initialization
    public class Singleton1
    {
        private static Singleton1 instance;
        private Singleton1()
        {
        }

        public static Singleton1 GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton1();
            }
            return instance;
        }

        public static void Main(string[] args)
        {
            Singleton1 obj1 = Singleton1.GetInstance();
            Console.WriteLine(obj1.GetHashCode());
            //obj1 & obj2 both will have same HashCode value
            Singleton1 obj2 = Singleton1.GetInstance();
            Console.WriteLine(obj2.GetHashCode());
        }

    }
}
