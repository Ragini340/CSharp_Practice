namespace CSharp_Practice.Collections.Generic.List
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
