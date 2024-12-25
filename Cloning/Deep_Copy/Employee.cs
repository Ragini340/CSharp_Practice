using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Cloning.Deep_Copy
{
    public class Employee : ICloneable
    {
        //These are no fields below are properties of Employee class
        public string EmpName {  get; set; }
        public int EmployeeId { get; set; }
        public string Department {  get; set; }
        public int DepartmentId { get; set; }
        public Address EmpAddress { get; set; }

        public Employee() { }

        public Object Clone()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            employee.EmpAddress = (Address)EmpAddress.Clone();
            return employee;
        }

        public override string ToString()
        {
            return "Name: " + this.EmpName + " EmployeeId: " + this.EmployeeId + " Department: " + this.Department + " DepartmentId: "
                + this.DepartmentId + " Address: " + EmpAddress.ToString();
        }

    } 
}
