using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Constructor
{
    public class Employee
    {
        string EmpName;
        int Id;
        string MngName;
        string DepartmentName;
        string TeamName;

        //Parametrized Constructor
        public Employee(string EmpName, int Id, string MngName, string DepartmentName, string TeamName)
        {
            this.EmpName = EmpName;
            this.Id = Id;
            this.MngName = MngName;
            this.DepartmentName = DepartmentName;
            this.TeamName = TeamName;
        }

        //Copy Constructor
        public Employee(string EmpName, int Id, Employee employee)
        {
            this.EmpName = EmpName;
            this.Id = Id;
            MngName = employee.MngName;
            DepartmentName = employee.DepartmentName;
            TeamName = employee.TeamName;
        }

        override public string ToString()
        {
            return "Name: " + this.EmpName + " Id: " + this.Id + "  Manager: " + this.MngName + " Department: " + this.DepartmentName + " TeamName: " + this.TeamName;
        }

    }
}