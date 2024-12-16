using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Indexer.Overloading_With_Indexer
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine("Total employees with gender Male: " + company["M"]);
            Console.WriteLine("Total employees with gender Female: " + company["F"]);
            Console.WriteLine();

            company["M"] = "F";
            Console.WriteLine("Updated total employees with gender Male: " + company["M"]);
            Console.WriteLine("Updated total employees with gender Female: " + company["F"]);
        }
    }
    
}
