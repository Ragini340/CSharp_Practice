using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Indexer
{
    public class EmployeeIndexerDriver
    {
        public static void Main()
        {
            EmployeeUsingIndexer employeeUsingIndexer = new EmployeeUsingIndexer(2, "Ragini", "De", 1000, "IT", "BLR", "Female");
            Console.WriteLine("Id is:" + employeeUsingIndexer[0]);
            Console.WriteLine("Name is:" + employeeUsingIndexer[1]);
            Console.WriteLine("Job is:" + employeeUsingIndexer[2]);
            Console.WriteLine("Salary is:" + employeeUsingIndexer[3]);
            Console.WriteLine("Location is:" + employeeUsingIndexer[4]);
            Console.WriteLine("Department is:" + employeeUsingIndexer[5]);
            Console.WriteLine("Gender is:" + employeeUsingIndexer[6]);
            Console.WriteLine();

            employeeUsingIndexer[0] = 1;
            employeeUsingIndexer[1] = "R";
            employeeUsingIndexer[2] = "Dev";

            Console.WriteLine("Id is:" + employeeUsingIndexer[0]);
            Console.WriteLine("Name is:" + employeeUsingIndexer[1]);
            Console.WriteLine("Job is:" + employeeUsingIndexer[2]);
            Console.WriteLine("Salary is:" + employeeUsingIndexer[3]);
            Console.WriteLine("Location is:" + employeeUsingIndexer[4]);
            Console.WriteLine("Department is:" + employeeUsingIndexer[5]);
            Console.WriteLine("Gender is:" + employeeUsingIndexer[6]);
        }
    }
}
