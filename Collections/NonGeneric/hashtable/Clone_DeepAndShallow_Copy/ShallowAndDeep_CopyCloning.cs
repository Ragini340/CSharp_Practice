using System;
using System.Collections;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.Collections.NonGeneric.hashtable.Clone_DeepCopy;

namespace CSharp_Practice.Collections.NonGeneric.hashtable.Clone_DeepAndShallow_Copy
{
    public class ShallowAndDeep_CopyCloning
    {
        public static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.EmployeeId = 1;
            employee1.Name = "Bree";

            Employee employee2 = new Employee();
            employee2.EmployeeId = 2;
            employee2.Name = "Susan";

            Hashtable hastable = new Hashtable();
            hastable.Add(employee1.EmployeeId, employee1);
            hastable.Add(employee2.EmployeeId, employee2);

            Console.WriteLine("Hashtable data:-");
            foreach (int key in hastable.Keys)
            {
                Console.WriteLine(hastable[key]);
            }
            Console.WriteLine();

            Hashtable cloned = (Hashtable)hastable.Clone();
            Console.WriteLine("Cloned data:-");
            foreach (int key in cloned.Keys)
            {
                Console.WriteLine(cloned[key]);
            }
            Console.WriteLine();

            Employee emp3 = (Employee)cloned[employee1.EmployeeId];
            emp3.Name = "Gaby";

            //This is shallow copy as values are getting updated in actual data and cloned data for EmployeId = 1 i.e. Name will be Gaby for actual hashtable and cloned
            //hashtable for EmployeId = 1.
            Console.WriteLine("Now Hashtable data:-");
            foreach (int key in hastable.Keys)
            {
                Console.WriteLine(hastable[key]);
            }
            Console.WriteLine();

            Console.WriteLine("Now Cloned data:-");
            foreach (int key in cloned.Keys)
            {
                Console.WriteLine(cloned[key]);
            }
            Console.WriteLine();

            //Deep copy
            CloneableEmployee cloneableEmployee = new CloneableEmployee();
            cloneableEmployee.EmployeeId = 3;
            cloneableEmployee.Name = "Mike";
            Console.WriteLine(cloneableEmployee); //Original data with one employee
            Console.WriteLine();

            Hashtable deepCopyHashtable = new Hashtable();
            deepCopyHashtable.Add(cloneableEmployee.EmployeeId, cloneableEmployee); //Adding original data with one employee into hashtable

            Hashtable clonedHashtable = (Hashtable)deepCopyHashtable.Clone(); //Cloning original data
            CloneableEmployee emp = (CloneableEmployee)clonedHashtable[cloneableEmployee.EmployeeId];

            CloneableEmployee cloneableEmployee1 = (CloneableEmployee)emp.Clone();
            cloneableEmployee1.Name = "Zach"; //Updating name
            clonedHashtable[cloneableEmployee1.EmployeeId] = cloneableEmployee1;


            Console.WriteLine("Updating name in cloned data:-");
            foreach (int key in clonedHashtable.Keys)
            {
                Console.WriteLine(clonedHashtable[key]);
            }
            Console.WriteLine();

            Console.WriteLine("Printing original hashtable:-");
            foreach (int key in deepCopyHashtable.Keys)
            {
                Console.WriteLine(deepCopyHashtable[key]);
            }
            Console.WriteLine();
        }
    }

}
