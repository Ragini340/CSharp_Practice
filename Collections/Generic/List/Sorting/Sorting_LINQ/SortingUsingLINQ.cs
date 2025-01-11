using CSharp_Practice.Collections.Generic.List.Sorting.Sorting_IComparer;

namespace CSharp_Practice.Collections.Generic.List.Sorting.Sorting_LINQ
{
    public class SortingUsingLINQ 
    {
        public static void Main(string[] args)
        {
           List<Employee> employees = new List<Employee>()
           {
           new Employee()
           {
            EmployeeId = 1,
            Name = "Bree",
            Gender = "F",
            Salary = 5000000
           },
           new Employee()
           {
            EmployeeId = 2,
            Name = "Mike",
            Gender = "M",
            Salary = 100000
           },
           new Employee()
           {
            EmployeeId = 3,
            Name = "Aasutosh",
            Gender = "M",
            Salary = 5000000
           }
         };

            Console.WriteLine("Employee's list:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            employees = employees.OrderBy(e => e.Name).ToList();
            Console.WriteLine("Sorting by employee's Name:-");
            foreach(Employee emp in employees)
            {
               Console.WriteLine(emp);
            }

            //Sorting in ascending order with the given customized sorting
            SortingUsingIComparer sortByName = new SortingUsingIComparer();
            employees =  employees.OrderBy(e => e,sortByName).ToList();
            Console.WriteLine("\nSorting using comparer:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            employees = employees.OrderByDescending(e =>( e.Name )).ToList();
            Console.WriteLine("\nSorting by employee's Name in decreasing order:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            //Descending order
            employees = employees.OrderByDescending(e => e, sortByName).ToList();
            Console.WriteLine("\nSorting using comparer:-");
            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}