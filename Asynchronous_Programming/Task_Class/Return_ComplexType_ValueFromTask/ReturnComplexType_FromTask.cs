namespace CSharp_Practice.Asynchronous_Programming.Task_Class.Return_ComplexType_ValueFromTask
{
    public class ReturnComplexType_FromTask
    {
        private async void Print()
        {
            Employee emp = await GetEmployeeDetails();
            Console.WriteLine($"Id: {emp.Id}, Name : {emp.Name}, Salary : {emp.Salary}");
        }

        public async Task<Employee> GetEmployeeDetails()
        {
            Employee employee = new Employee()
            {
                Id = 100,
                Name = "Mike",
                Salary = 10000
            };

            return employee;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            ReturnComplexType_FromTask complexType_FromTask = new ReturnComplexType_FromTask();
            complexType_FromTask.Print();
            Console.WriteLine("Main thread completed");
        }

    }
}