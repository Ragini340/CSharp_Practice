namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Prototype_Design_Pattern
{
    public class FullTimeEmployee : Employee
    {
        public int Salary { get; set; }
        public override Employee GetClone()
        {
            //MemberwiseClone method creates a shallow copy of the current object, so typecasting the object,
            //in this case, typecasting to PermanentEmployee type
            return (FullTimeEmployee)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Fulltime employee:-");
            Console.WriteLine($"Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, Salary: {this.Salary}\n");
        }

    }
}