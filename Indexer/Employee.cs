namespace CSharp_Practice.Indexer
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }

        public Employee(int Id, string Name, string Job, double Salary, string Location, string Department, string Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
            this.Location = Location;
            this.Department = Department;
            this.Gender = Gender;
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Rag", "Dev", 100000000, "BLR", "IT", "F");
            //Console.WriteLine("Employee Id: " + employee[0]); It will throw error: Cannot apply indexing with [] to an expression of type 'type'
            //This is because we cannot apply indexing directly to a class.
            //We can do indexing on an array but we cannot do the same thing with a user-defined class like Employee.
            //An array is a predefined class and all the logic is implemented in that class for indexing so that we can access them using indexes.
            //But Employee is a user-defined class and we have not implemented any logic to access the class like an array.
        }

    }
}