using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CallByValue_CallByReference
{
    public class CallByReferenceWithReferenceTypes
    {
        public static void Main(string[] args)
        {
            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 1001;
            Emp1.Name = "Ragini";
            UpdateName(ref Emp1);
            Console.WriteLine($"Emp1 Name = {Emp1.Name}"); //Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
        }

        public static void UpdateName(ref Employee Emp2)
        {
            Emp2 = null;
        }
    }
}