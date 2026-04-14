using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CallByValue_CallByReference
{
    public class CallByValueWithReferenceTypes
    {
        public static void Main(string[] args)
        {
            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 1001;
            Emp1.Name = "Ragini";
            Employee Emp2 = Emp1;
            Emp1.Name = "R";
            Console.WriteLine($"Emp1 Name = {Emp1.Name}");
            Console.WriteLine($"Emp2 Name = {Emp2.Name}");
        }
    }
}