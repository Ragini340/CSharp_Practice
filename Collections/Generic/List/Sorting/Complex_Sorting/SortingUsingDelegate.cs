namespace CSharp_Practice.Collections.Generic.List.Sorting.Complex_Sorting
{
    public class SortingUsingDelegate
    {
        //Comparison Delegate:-
        private static int CompareEmployees(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
              new Employee
              {
               EmployeeId = 1,
               Name = "Bree",
               Gender = "F",
               Salary = 5000
              },
              new Employee
              {
               EmployeeId = 2,
               Name = "Susan",
               Gender = "F",
               Salary = 2000
              },
              new Employee
              {
               EmployeeId = 3,
               Name = "Gaby",
               Gender = "F",
               Salary = 3000
              },
              new Employee
              {
               EmployeeId = 4,
               Name = "Mike",
               Gender = "M",
               Salary = 5000
              }
            };

            Console.WriteLine("Original employee list elements are:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            Comparison<Employee> employeeComparer = new Comparison<Employee>(CompareEmployees);
            employees.Sort(employeeComparer);
            Console.WriteLine("\nSorting using Comparison Delegate:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            //Comparison Delegate with Anonymous Method:-
            employees.Sort(delegate (Employee x, Employee y) { return x.Name.CompareTo(y.Name); });
            Console.WriteLine("\nSorting using Comparison Delegate with Anonymous method:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            //Comparison Delegate with Lambda Expression:-
            employees.Sort((x, y) => { return x.Name.CompareTo(y.Name); });
            Console.WriteLine("\nSorting using Comparison Delegate with Lambda Expression:-");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

        }
    }

}