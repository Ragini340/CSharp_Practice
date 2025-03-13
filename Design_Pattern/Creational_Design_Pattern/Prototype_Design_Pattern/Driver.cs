namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Prototype_Design_Pattern
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new FullTimeEmployee()
            {
                Name = "Ragini",
                Department = "IT",
                Type = "Permanent",
                Salary = 1500000
            };

            Employee emp2 = emp1.GetClone();
            //Changing the Name and Department property value of emp2 instance, will not change the Name and Department property
            //value of the emp1 instance
            emp2.Name = "Bree";
            emp2.Department = "Sales";
            emp1.ShowDetails();
            emp2.ShowDetails();

            Employee emp3 = new ContractEmployee()
            {
                Name = "Gaby",
                Department = "HR",
                Type = "Contract",
                FixedAmount = 1000000
            };

            Employee emp4 = emp3.GetClone();
            //Changing the Name and Department property value of emp4 instance, will not change the Name and Department property
            //value of the emp3 instance
            emp4.Name = "Susan";
            emp4.Department = "Marketing";
            emp3.ShowDetails();
            emp4.ShowDetails();
        }

    }
}