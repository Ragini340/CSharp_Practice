using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Indexer
{
    public class StringIndexerDriver
    {
        public static void Main(string[] args)
        {
            StringIndexer stringIndexer = new StringIndexer(100, "PQR", "SDE", 10000000, "Mumbai", "IT", "Male");
            Console.WriteLine("Id: " + stringIndexer["Id"]);
            Console.WriteLine("Name: " + stringIndexer["Name"]);
            Console.WriteLine("Job: " + stringIndexer["Job"]);
            Console.WriteLine("Salary: " + stringIndexer["Salary"]);
            Console.WriteLine("Location: " + stringIndexer["Location"]);
            Console.WriteLine("Department: " + stringIndexer["Department"]);
            Console.WriteLine("Gender: " + stringIndexer["Gender"]);
            Console.WriteLine();

            stringIndexer["Name"] = "Xyz";
            stringIndexer["Salary"] = 5000;
            stringIndexer["Location"] = "BLR";

            Console.WriteLine("Id: " + stringIndexer["Id"]);
            Console.WriteLine("Name: " + stringIndexer["Name"]);
            Console.WriteLine("Job: " + stringIndexer["Job"]);
            Console.WriteLine("Salary: " + stringIndexer["Salary"]);
            Console.WriteLine("Location: " + stringIndexer["Location"]);
            Console.WriteLine("Department: " + stringIndexer["Department"]);
            Console.WriteLine("Gender: " + stringIndexer["Gender"]);
        }
    }
}
