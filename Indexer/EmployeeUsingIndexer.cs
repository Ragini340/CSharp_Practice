using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Indexer
{
    public class EmployeeUsingIndexer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }

        public EmployeeUsingIndexer(int Id, string Name, string Job, int Salary, string Department, string Location, string Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
            this.Location = Location;
            this.Department = Department;
            this.Gender = Gender;
        }

        //Indexer creation
        public object this[int index] 
            //public: Access Modifier
            //object: This is return type and here we are returning integer and string member's value, so it's return type is object
            //this: keyword
            //[int index]: indexer of integer
        {
            get
            {
                //Based on the index position returning the property value
                if (index == 0)
                {
                    return Id;
                }
                else if (index == 1)
                {
                    return Name;
                }
                else if (index == 2)
                {
                    return Job;
                }
                else if (index == 3)
                {
                    return Salary;
                }
                else if (index == 5)
                {
                    return Location;
                }
                else if (index == 4)
                {
                    return Department;
                }
                else if (index == 6)
                {
                    return Gender;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                //Based on the index position setting the property value
                if (index == 0)
                {
                    Id = Convert.ToInt32(value);
                }
                else if (index == 1)
                {
                    Name = value.ToString();
                }
                else if (index == 2)
                {
                    Job = value.ToString();
                }
                else if (index == 3)
                {
                    Salary = Convert.ToDouble(value);
                }
                else if (index == 5)
                {
                    Location = value.ToString();
                }
                else if (index == 4)
                {
                    Department = value.ToString();
                }
                else if (index == 6)
                {
                    Gender = value.ToString();
                }
            }
        }

    }
}
