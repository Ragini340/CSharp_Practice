namespace CSharp_Practice.Collections.Generic.List
{
    public class EmployeeDetails
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
        public DateTime DOJ { get; set; }

        public override string ToString()
        {
            return "EmployeeId: " + EmployeeId + " Name: " + Name + " Salary: " + Salary + " Department: " + Department + " DOJ: " + DOJ;
        }
    }
}
