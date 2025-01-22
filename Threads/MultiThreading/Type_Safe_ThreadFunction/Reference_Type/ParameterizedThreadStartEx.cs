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

        public void DisplayEmployeeListUsingDelegate(object employeesList)
        {
            List<Employee> emp = (List<Employee>)employeesList;
            Thread thread2 = new Thread(delegate (object? employeesList)
            {
                foreach (var item in emp)
                {
                    Console.WriteLine("Using delegate: " + item);
                }
            });
            thread2.Start(employeesList);
        }

        public void DisplayEmployeeListUsingLambda(object employeesList)
        {
            List<Employee> emp = (List<Employee>)employeesList;
            Thread thread3 = new Thread(employeesList =>
            {
                foreach (var item in emp)
                {
                    Console.WriteLine("Using Lambda: " + item);
                }
            });
            thread3.Start(employeesList);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            Employee employee1 = new Employee()
            {
                EmployeeId = 1,
                Name = "Ragini",
                Gender = "F",
                Salary = 100000
            };
            Employee employee2 = new Employee()
            {
                EmployeeId = 2,
                Name = "Bree",
                Gender = "F",
                Salary = 80000
            };
            Employee employee3 = new Employee()
            {
                EmployeeId = 3,
                Name = "Gaby",
                Gender = "F",
                Salary = 60000
            };
            Employee employee4 = new Employee()
            {
                EmployeeId = 4,
                Name = "Mike",
                Gender = "M",
                Salary = 600000
            };

            List<Employee> employeesList = new List<Employee>();
            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            employeesList.Add(employee4);

            ParameterizedThreadStartEx obj = new ParameterizedThreadStartEx();
            Thread thread1 = new Thread(obj.DisplayEmployeeList);
            thread1.Start(employeesList);
            obj.DisplayEmployeeListUsingDelegate(employeesList);
            obj.DisplayEmployeeListUsingLambda(employeesList);
            Console.WriteLine("Main thread ended");
        }

    }
}