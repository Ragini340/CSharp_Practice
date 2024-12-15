using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Indexer.Indexer_Real_Life_Example
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine("Name of Employee with EmployeeId 1: " + company[1]);
            Console.WriteLine("Name of Employee with EmployeeId 2: " + company[2]);
            Console.WriteLine("Name of Employee with EmployeeId 3: " + company[3]);
            Console.WriteLine("Name of Employee with EmployeeId 4: " + company[4]);
            Console.WriteLine("Name of Employee with EmployeeId 5: " + company[5]);
            Console.WriteLine();

            company[1] = "AA";
            company[2] = "BB";
            company[3] = "CC";

            Console.WriteLine("Updated Name of the Employee with EmployeeId 1: " + company[1]);
            Console.WriteLine("Updated Name of the Employee with EmployeeId 2: " + company[2]);
            Console.WriteLine("Updated Name of the Employee with EmployeeId 3: " + company[3]);
        }
    }
}
