namespace CSharp_Practice.Threads.MultiThreading.Type_Safe_ThreadFunction.Reference_Type
{
    public class ParameterizedThreadStartEx
    {
        public void DisplayEmployeeList(object employeesList)
        {
            List<Employee> emp = (List<Employee>)employeesList;
            foreach (var item in emp)
            {
                Console.WriteLine("Using normal approach: " + item);
            }
        }

        //public delegate void DisplayEmployeeListUsingAnonymousMethod(object employeesList);

        //public delegate void DisplayEmployeeListUsingLambda(object employeesList);

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
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(obj.DisplayEmployeeList);
            Thread thread1 = new Thread(parameterizedThreadStart);
            thread1.Start(employeesList);

            ParameterizedThreadStart parameterizedThreadStart1 = delegate (object? employeesList)
            {
                List<Employee> emp = (List<Employee>)employeesList;
                foreach (var item in emp)
                {
                    Console.WriteLine("Thread2 using Anonymous method: " + item);
                }
            };
            Thread thread2 = new Thread(parameterizedThreadStart1);
            thread2.Start(employeesList);

            ParameterizedThreadStart parameterizedThreadStart2 = employeesList =>
            {
                List<Employee> emp = (List<Employee>)employeesList;
                foreach (var item in emp)
                {
                    Console.WriteLine("Thread3 using Lambda: " + item);
                }
            };
            Thread thread3 = new Thread(parameterizedThreadStart2);
            thread3.Start(employeesList);

            //Shortcut to write above thread1, thread2, and thread3 as below in thread4, thread5, and thread6 respectively:-
            Thread thread4 = new Thread(new ParameterizedThreadStart(obj.DisplayEmployeeList));
            thread4.Start(employeesList);

            Thread thread5 = new Thread(delegate (object? employeesList)
            {
                List<Employee> emp = (List<Employee>)employeesList;
                foreach (var item in emp)
                {
                    Console.WriteLine("Thread5 using Anonymous method: " + item);
                }
            });
            thread5.Start(employeesList);

            Thread thread6 = new Thread(employeesList =>
            {
                List<Employee> emp = (List<Employee>)employeesList;
                foreach (var item in emp)
                {
                    Console.WriteLine("Thread6 using Lambda: " + item);
                }
            });
            thread6.Start(employeesList);

            /*Thread thread7 = new Thread(parametrizedThreadStarterObj =>
            {
                List<Employee> emp = (List<Employee>)parametrizedThreadStarterObj;
                foreach (var item in emp)
                {
                    Console.WriteLine("Using Lambda: " + item);
                }
            });
            thread7.Start(employeesList);*/
            Console.WriteLine("Main thread ended");
        }

    }
}