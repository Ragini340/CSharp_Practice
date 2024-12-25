using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Cloning.Shallow_Copy
{
    public class EmployeeDriver
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmpName = "Ragini";
            employee.EmployeeId = 1;
            employee.Department = "TSS";
            employee.DepartmentId = 2;
            employee.EmpAddress = new Address()
            {
                CityName = "Bangalore",
                StateName = "Karnataka",
                PinCode = 560061
            };

            Employee clonedEmployee = (Employee)employee.Clone();

            Console.WriteLine("Original employee details:- ");
            Console.WriteLine(employee);
            Console.WriteLine(employee.GetHashCode());

            Console.WriteLine("Cloned employee details:- ");
            Console.WriteLine(clonedEmployee);
            Console.WriteLine(clonedEmployee.GetHashCode());

            //Scenario 1
            //Let's try to change Address's CityName for cloned Employee Address.---It means we are changing value for reference type. 
            Console.WriteLine("Change CityName in cloned employee address:-");
            Address clonedEmployeeadreess = clonedEmployee.EmpAddress;

            clonedEmployeeadreess.CityName = "Kolkata";
            Console.WriteLine("Original employee after changing address in cloned employee");
            Console.WriteLine(employee);
            Console.WriteLine("Cloned employee details after changing Address's CityName in cloned employee");
            Console.WriteLine(clonedEmployee);
            Console.WriteLine("Hashcode of Address of cloned Employee: " + clonedEmployee.EmpAddress.GetHashCode());
            Console.WriteLine("Hashcode of Adress of original employee: " + employee.EmpAddress.GetHashCode());

            //In above we can see CityName changes in original employee address and cloned employee address because both employee has same Address object.
            //It means when it copies Address from Employee to clone employee, It does not create new object for Address in cloned employee, It just creates copy of reference which points 
            //to same Address object which is for original Employee. --- Then How can we test that? Is it pointing to original EmpAddress? 
            //Try to print Hashcode of EmployeeAddress and cloned EmployeeAddress and we will get same hashcode for employee address and cloned employee address 
            //becuase both EmployeeAddress and cloned EmployeeAddress are pointing to same Address object in memory.

            //Scenario 2
            //Let's try to change in value type data for cloned Employee --> Change EmpName and check whether original EmpName also changed or only cloned EmpName has changed.
            clonedEmployee.EmpName = "Priya";
            Console.WriteLine("Changed employee name in cloned employee:-");
            Console.WriteLine("Now original employee details:");
            Console.WriteLine(employee);
            Console.WriteLine("Now Cloned  employee details:");
            Console.WriteLine(clonedEmployee);

            Console.WriteLine("Hashcode of original and cloned employees:-");
            Console.WriteLine(employee.GetHashCode());
            Console.WriteLine(clonedEmployee.GetHashCode());

            //Scenario 3: Now change Address CityName in original employee 
            employee.EmpAddress.CityName = "Varansi";
            Console.WriteLine("Original Employee details: ");
            Console.WriteLine(employee);
            Console.WriteLine("Cloned Employee details: ");
            Console.WriteLine(clonedEmployee);

            //Scenario 4: Now Change Employee Name in original employee
            employee.EmpName = "Nick";
            Console.WriteLine("Original Employee details: ");
            Console.WriteLine(employee);
            Console.WriteLine("Cloned Employee details: ");
            Console.WriteLine(clonedEmployee);
        }

    }
}
