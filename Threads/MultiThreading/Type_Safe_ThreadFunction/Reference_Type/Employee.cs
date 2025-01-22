namespace CSharp_Practice.Threads.MultiThreading.Type_Safe_ThreadFunction.Reference_Type
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return "EmployeeId: " + EmployeeId + " Name: " + Name + " Gender: " + Gender + " Salary: " + Salary;
        }

    }
}