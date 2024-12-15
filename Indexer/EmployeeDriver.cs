using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Factory_Design_Pattern.Factory_Design_Vehicle;
using Newtonsoft.Json.Linq;

namespace CSharp_Practice.Indexer
{
    public class EmployeeDriver
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Rag", "Dev", 100000000, "BLR", "IT", "F");
            //Console.WriteLine("Employee Id: " + employee[0]); It will throw error: Cannot apply indexing with [] to an expression of type 'type'
            //This is because we cannot apply indexing directly to a class.
            //We can do indexing on an array but we cannot do the same thing with a user-defined class like Employee.
            //An array is a predefined class and all the logic is implemented in that class for indexing so that we can access them using indexes.
            //But Employee is a user-defined class and we have not implemented any logic to access the class like an array.
        }
    }
}
