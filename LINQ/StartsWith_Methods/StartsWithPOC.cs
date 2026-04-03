using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.Threads.MultiThreading.Synchronization.Using_Mutex;

namespace CSharp_Practice.LINQ.StartsWith_Methods
{
    /*Count words starting with letter 'A' using LINQ.*/
    public class StartsWithPOC
    {
        public static void CountWords()
        {
            List<string> words = new List<string>
            {
            "Apple",
            "Ant",
            "Ball",
            "Animal",
            "Cat"
            };

            int count = words.Count(w => w.StartsWith("A"));

            Console.WriteLine($"Count: {count}");
        }

        public static void Main(string[] args)
        {
            CountWords();
        }
    }
}