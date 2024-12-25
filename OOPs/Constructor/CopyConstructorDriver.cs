using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Constructor
{
    public class CopyConstructorDriver
    {
        public static void Main(string[] args)
        {
            //Without using copy constructor we are creating object obj2  using same like obj1.
            CopyConstructor obj1 = new CopyConstructor("Apr", 2000);
            CopyConstructor obj2 = new CopyConstructor("Apr", 2000);//Passing all pramater again to create obj2. This is error prone and time consuming if huge data is there in constructor parameter
                                                                    //Console.WriteLine(obj1.ToString());
                                                                    //Console.WriteLine(obj2.ToString());


            //Here, if we know that obj12 needs same data like obj11 then we do not use obj11, so we are using obj11 to copy same data in obj12.
            CopyConstructor obj11 = new CopyConstructor("Jun", 2000);
            CopyConstructor obj12 = new CopyConstructor(obj1);
            //Console.WriteLine(obj11.ToString());
            //Console.WriteLine(obj12.ToString());

            //Scenario 2: Here we are using common department name manager and team name from other object using copy constructor technique because we need to print list of employee of same team who has same team, manager and teamname.
            Employee employee1 = new Employee("Ragini", 1, "Amit", "TSS", "Admin");
            Employee employee2 = new Employee("Rita", 10, employee1);
            Employee employee3 = new Employee("Gita", 11, employee1);
            Employee employee4 = new Employee("Sita", 12, employee1);
            Employee employee5 = new Employee("Nita", 13, employee1);
            Employee employee6 = new Employee("Nisha", 14, employee1);
            Employee employee7 = new Employee("Anisha", 15, employee1);
            Employee employee8 = new Employee("Divya", 16, employee1);
            Employee employee9 = new Employee("Bree", 17, employee1);
            Employee employee10 = new Employee("Susan", 18, employee1);

            Console.WriteLine(employee1.ToString());
            Console.WriteLine(employee2.ToString());
            Console.WriteLine(employee3.ToString());
            Console.WriteLine(employee4.ToString());
            Console.WriteLine(employee5.ToString());
            Console.WriteLine(employee6.ToString());
            Console.WriteLine(employee7.ToString());
            Console.WriteLine(employee8.ToString());
            Console.WriteLine(employee9.ToString());
            Console.WriteLine(employee10.ToString());
        }

    }
}
