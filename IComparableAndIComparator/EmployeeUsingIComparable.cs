using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.IComparableAndIComparator
{
    public class EmployeeUsingIComparable : IComparable<EmployeeUsingIComparable>
    {
        private int empId;
        private string empName;
        private int empAge;

        public EmployeeUsingIComparable(int empId, string empName, int empAge)
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

        public int CompareTo(EmployeeUsingIComparable employee)
        {
            return empAge.CompareTo(employee.empAge);  //a.compareTo(b)     1 if a-b > 0   i.e a > b
                                                       //                   -1 if a-b < 0  i.e. a < b 
                                                       //                    0 if a==b     i.e. a = b
        }

        public static void Main(string[] args)
        {
            List<EmployeeUsingIComparable> list = new List<EmployeeUsingIComparable>();
            list.Add(new EmployeeUsingIComparable(100, "KAGINI", 30));
            list.Add(new EmployeeUsingIComparable(600, "PRIYANLA", 42));
            list.Add(new EmployeeUsingIComparable(30, "NIKHI", 41));
            list.Add(new EmployeeUsingIComparable(50, "JINY", 10));
            list.Add(new EmployeeUsingIComparable(500, "GUNJAN", 50));

            Console.WriteLine("Before sorting employee age:");
            foreach (var emp in list)
            {
                Console.WriteLine(emp.GetEmployeeAge());
            }
            Console.WriteLine();

            Console.WriteLine("After sorting employee age:");
            list.Sort();
            foreach (var emp in list)
            {
                Console.WriteLine(emp.GetEmployeeAge());
            }
        }

    }
}