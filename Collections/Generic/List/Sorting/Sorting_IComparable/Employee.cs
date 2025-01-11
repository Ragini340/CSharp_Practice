namespace CSharp_Practice.Collections.Generic.List.Sorting.Sorting_IComparable
{
    public class Employee : IComparable<Employee>
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee employee)
        {
            if (Salary > employee.Salary) // a - b > 0
            {
                return 1;
            }
            else if (Salary < employee.Salary) // a - b < 0
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "EmployeeId: " + EmployeeId + " Name: " + Name + " Gender: " + Gender + " Salary: " + Salary;
        }
    }
}
