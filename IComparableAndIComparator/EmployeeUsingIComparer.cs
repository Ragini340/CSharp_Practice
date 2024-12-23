using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.IComparableAndIComparator
{
    public class EmployeeUsingIComparer
    {
        private int empId;
        private string empName;
        private int empAge;

        public EmployeeUsingIComparer(int empId, string empName, int empAge)
        {
            this.empId = empId;
            this.empName = empName;
            this.empAge = empAge;
        }

        public string GetEmployeeName()
        {
            return empName;
        }

        public void SetEmployeeName(string empName)
        {
            this.empName = empName;
        }

        public int GetEmployeeID()
        {
            return empId;
        }

        public void SetEmployeeID(int empId)
        {
            this.empId = empId;
        }

        public int GetEmployeeAge()
        {
            return empAge;
        }

        public void SetEmployeeAge(int empAge)
        {
            this.empAge = empAge;
        }
    }

    public class EmployeeComparer : IComparer<EmployeeUsingIComparer>
    {
        private String sortBy;
        EmployeeComparer(string sortBy)
        {
            this.sortBy = sortBy;
        }

        public int Compare(EmployeeUsingIComparer x, EmployeeUsingIComparer y)
        {
            if (sortBy.Equals("name"))
            {
                return x.GetEmployeeName().CompareTo(y.GetEmployeeName());
            }
            else if (sortBy.Equals("age"))
            {
                return x.GetEmployeeAge().CompareTo(y.GetEmployeeAge());
            }
            return x.GetEmployeeID().CompareTo(y.GetEmployeeID());  //If we pass random string as input, it will sort by default with EmployeeId. 

            //We can write customize logic in own way as below: ------------------
            /*
            if (sortyBy.Equals("name"))
            {
                if (x.GetEmployeeName().CompareTo(y.GetEmployeeName()) == 1) 
                {
                    return -1;  //Sorting in descending order by name 
                } 
                else if (x.GetEmployeeName().CompareTo (y.GetEmployeeName()) == -1)
                {
                    return 1; //Sorting in ascending order by name 
                }
            } 
            return 0;
             */
        }

        public static void Main(string[] args)
        {
            List<EmployeeUsingIComparer> list = new List<EmployeeUsingIComparer>();
            list.Add(new EmployeeUsingIComparer(100, "KAGINI", 30));
            list.Add(new EmployeeUsingIComparer(600, "PRIYANLA", 42));
            list.Add(new EmployeeUsingIComparer(30, "NIKHI", 41));
            list.Add(new EmployeeUsingIComparer(50, "JINY", 10));
            list.Add(new EmployeeUsingIComparer(500, "GUNJAN", 50));

            //Sorting the person with employee Name  
            EmployeeComparer sortByName = new EmployeeComparer("name");
            Console.WriteLine("Before sorting by name:");
            foreach (var emp in list)
            {
                Console.WriteLine(emp.GetEmployeeName() + " " + emp.GetEmployeeID());
            }
            Console.WriteLine();

            list.Sort(sortByName);
            Console.WriteLine("After sorting by name:");
            foreach (var emp in list)
            {
                Console.WriteLine(emp.GetEmployeeName() + " " + emp.GetEmployeeID());
            }
            Console.WriteLine();

            //Sorting the person with employee Age 
            EmployeeComparer sortByAge = new EmployeeComparer("age");
            Console.WriteLine("Before sorting by age:");
            foreach (var emp in list)
            {
                Console.WriteLine(emp.GetEmployeeAge() + " " + emp.GetEmployeeName());
            }
            Console.WriteLine();

            list.Sort(sortByAge);
            Console.WriteLine("After sorting by age:");
            foreach (var emp in list)
            {
                Console.WriteLine(emp.GetEmployeeAge() + " " + emp.GetEmployeeName());
            }
            Console.WriteLine();

            //Default sorting (by EmployeeId)
            EmployeeComparer sortByEmployeeId = new EmployeeComparer("");
            Console.WriteLine("Before sorting by EmployeeId:");
            foreach (var emp in list)
            {
                Console.WriteLine(emp.GetEmployeeID() + " " + emp.GetEmployeeName());
            }
            Console.WriteLine();

            list.Sort(sortByEmployeeId);
            Console.WriteLine("After sorting by EmployeeId");
            foreach (var emp in list)
            {
                Console.WriteLine(emp.GetEmployeeID() + " " + emp.GetEmployeeName());
            }
        }
    }

}
