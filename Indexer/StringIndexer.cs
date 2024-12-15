using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Indexer
{
    public class StringIndexer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }

        public StringIndexer(int Id, string Name, string Job, int Salary, string Location,
                        string Department, string Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
            this.Location = Location;
            this.Department = Department;
            this.Gender = Gender;
        }

        public object this[string index]
        {
            get
            {
                if (index == "Id")
                {
                    return Id;
                }
                else if (index == "Name")
                {
                    return Name;
                }
                else if (index == "Job")
                {
                    return Job;
                }
                else if (index == "Salary")
                {
                    return Salary;
                }
                else if (index == "Location")
                {
                    return Location;
                }
                else if (index == "Department")
                {
                    return Department;
                }
                else if (index == "Gender")
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
                if (index == "Id")
                {
                    Id = Convert.ToInt32(value);
                }
                else if (index == "Name")
                {
                    Name = value.ToString();
                }
                else if (index == "Job")
                {
                    Job = value.ToString();
                }
                else if (index == "Salary")
                {
                    Salary = Convert.ToDouble(value);
                }
                else if (index == "Location")
                {
                    Location = value.ToString();
                }
                else if (index == "Department")
                {
                    Department = value.ToString();
                }
                else if (index == "Gender")
                {
                    Gender = value.ToString();
                }
            }

        }
    }
}
