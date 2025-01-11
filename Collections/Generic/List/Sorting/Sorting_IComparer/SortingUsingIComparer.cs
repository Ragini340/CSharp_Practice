namespace CSharp_Practice.Collections.Generic.List.Sorting.Sorting_IComparer
{
    public class SortingUsingIComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public static void Main(string[] args)
        {
           List<Employee> employees = new List<Employee>()
           {
           new Employee()
           {
            EmployeeId = 1,
            Name = "Bree",
            Gender = "F",
            Salary = 500000
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
           
            SortingUsingIComparer sortByName = new SortingUsingIComparer();
            employees.Sort(sortByName);
            Console.WriteLine("\nSorting by employee's Name:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}