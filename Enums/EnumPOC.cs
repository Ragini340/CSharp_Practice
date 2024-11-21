using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Enums
{
    public class EnumPOC
    {
        public enum Season
        {
            Winter,
            Spring,
            Summer
        }

        public static void Main()
        {
            int x = (int)Season.Winter;
            int y = (int)Season.Spring;
            int z = (int)Season.Summer;
            Console.WriteLine("Winter = {0}", x);
            Console.WriteLine("Spring = {0}", y);
            Console.WriteLine("Summer = {0}", z);
        }

    }
}
