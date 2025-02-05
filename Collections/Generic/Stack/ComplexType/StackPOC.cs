namespace CSharp_Practice.Collections.Generic.Stack.ComplexType
{
    public class StackPOC
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                EmployeeId = 100,
                Name = "Mike",
                Gender = "Male",
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                EmployeeId = 101,
                Name = "Susan",
                Gender = "Female",
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                EmployeeId = 102,
                Name = "Carl",
                Gender = "Male",
                Salary = 30000
            };
            Employee emp4 = new Employee()
            {
                EmployeeId = 103,
                Name = "Bree",
                Gender = "Female",
                Salary = 40000
            };
            Employee emp5 = new Employee()
            {
                EmployeeId = 104,
                Name = "Gabby",
                Gender = "Female",
                Salary = 50000
            };

            Stack<Employee> employees = new Stack<Employee>();
            employees.Push(emp1);
            employees.Push(emp2);
            employees.Push(emp3);
            employees.Push(emp4);
            employees.Push(emp5);
            Console.WriteLine("Employee's details are: ");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            //Pop
            Employee e1 = employees.Pop();
            Console.WriteLine("\n" + e1);
            Employee e2 = employees.Pop();
            Console.WriteLine(e2);
            Employee e3 = employees.Pop();
            Console.WriteLine(e3);
            Employee e4 = employees.Pop();
            Console.WriteLine(e4);
            Employee e5 = employees.Pop();
            Console.WriteLine(e5);

            //Push
            employees.Push(emp1);
            employees.Push(emp2);
            employees.Push(emp3);
            employees.Push(emp4);
            employees.Push(emp5);

            //Peek
            Employee employee = employees.Peek();
            Console.WriteLine("\n" + employee);

            //Contains
            if (employees.Contains(emp3))
            {
                Console.WriteLine("\nemp3 is in stack");
            }
            else
            {
                Console.WriteLine("\nemp3 is not in stack");
            }
        }

    }
}