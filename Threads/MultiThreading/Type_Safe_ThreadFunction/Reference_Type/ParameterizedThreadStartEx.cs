namespace CSharp_Practice.Threads.MultiThreading.Type_Safe_ThreadFunction.Reference_Type
{
    public class ParameterizedThreadStartEx
    {
        public void DisplayEmployeeList(object employeesList)
        {
            List<Employee> emp = (List<Employee>)employeesList;
            foreach (var item in emp)
            {
                Console.WriteLine("Normal approach: " + item);
            }
        }

        public delegate void DisplayEmployeeListUsingAnonymousMethod(object employeesList);

        public delegate void DisplayEmployeeListUsingLambda(object employeesList);

        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            List<Employee> employeesList = new List<Employee>
            {
                new Employee
                {
                EmployeeId = 1,
                Name = "Ragini",
                Gender = "F",
                Salary = 100000
                },
                new Employee
                {
                EmployeeId = 2,
                Name = "Bree",
                Gender = "F",
                Salary = 80000
                },
                new Employee
                {
                EmployeeId = 3,
                Name = "Gaby",
                Gender = "F",
                Salary = 60000
                },
                new Employee
                {
                EmployeeId = 4,
                Name = "Mike",
                Gender = "M",
                Salary = 600000
                }
            };

            ParameterizedThreadStartEx obj = new ParameterizedThreadStartEx();
            Thread thread1 = new Thread(obj.DisplayEmployeeList);
            thread1.Start(employeesList);

            DisplayEmployeeListUsingAnonymousMethod displayEmployeeListUsingAnonymousMethod = delegate (object employeesList)
            {
                List<Employee> emp = (List<Employee>)employeesList;
                foreach (var item in emp)
                {
                    Console.WriteLine("Using Anonymous method: " + item);
                }
            };

            DisplayEmployeeListUsingLambda displayEmployeeListUsingLambda = employeesList =>
            {
                List<Employee> emp = (List<Employee>)employeesList;
                foreach (var item in emp)
                {
                    Console.WriteLine("Using Lambda: " + item);
                }
            };

            Thread thread2 = new Thread(displayEmployeeListUsingAnonymousMethod.Invoke);
            thread2.Start(employeesList);

            Thread thread3 = new Thread(displayEmployeeListUsingLambda.Invoke);
            thread3.Start(employeesList);
            Console.WriteLine("Main thread ended");
        }

    }
}