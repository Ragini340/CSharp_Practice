using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.HashSet
{
    public class RemoveWhereMethodInHashSet
    {
        public static void Main()
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < 10; i++)
            {
                set.Add(i);
            }

            Console.WriteLine("Elements in HashSet are: ");
            foreach (int value in set)
            {
                Console.WriteLine(value);
            }

            //Remove Method
            if (set.Contains(9))
            {
                set.Remove(9);
            }
            Console.WriteLine("Elements in HashSet after removing Element 9:");
            foreach (int value in set)
            {
                Console.WriteLine(value);
            }

            //RemoveWhere Method
            set.RemoveWhere(isEven);

            Console.WriteLine("Elements in HashSet after calling RemoveWhere Method:");
            foreach (int value in set)
            {
                Console.WriteLine(value);
            }
        }

        private static bool isEven(int i)
        {
            return (i % 2 == 0);
        }

    }
}
