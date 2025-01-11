namespace CSharp_Practice.Collections.Generic.List.Sorting.Sorting_IComparable
{
    public class SortingUsingIComparable
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
          
            employees.Sort();
            Console.WriteLine("\nSorting on the basis of salary in ascending order:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }

}