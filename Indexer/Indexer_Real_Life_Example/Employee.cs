namespace CSharp_Practice.Collections.Generic.Stack.ComplexType
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return "EmployeeId: " + this.EmployeeId + " Name: " + this.Name + " Gender: " + this.Gender + " Salary: " + this.Salary;
        }
    }
}