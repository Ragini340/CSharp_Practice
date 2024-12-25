using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Cloning.Shallow_Copy
{
    public class Employee : ICloneable
    {
        //These are not fields these are class properties
        public string EmpName { get; set; }
        public int EmployeeId { get; set; }
        public string Department { get; set; }
        public int DepartmentId { get; set; }
        public Address EmpAddress { get; set; }

        public Employee() { }

        public Object Clone()
        {
            return (Employee)MemberwiseClone();
        }

        public override string ToString()
        {
            return "Name: " + EmpName + " EmployeeId: " + EmployeeId + " Department: " + Department + " DepartmentId: "
                + DepartmentId + " Address: " + EmpAddress.ToString();
        }

    }
}
