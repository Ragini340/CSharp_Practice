using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Garbage_Collector.Properties
{
    //This property in the GC class returns the total number of generations
    public class MaxGenerationProperty
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Garbage collection maximum generations are: " + GC.MaxGeneration);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
    }
}
