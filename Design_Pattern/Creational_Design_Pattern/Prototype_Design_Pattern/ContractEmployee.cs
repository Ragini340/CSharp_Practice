namespace CSharp_Practice.Design_Pattern.Creational_Design_Pattern.Prototype_Design_Pattern
{
    public class ContractEmployee : Employee
    {
        public int FixedAmount { get; set; }
        public override Employee GetClone()
        {
            //MemberwiseClone method creates a shallow copy of the current object, so typecasting the object,
            //in this case, typecasting to ContractEmployee type
            return (ContractEmployee)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Contract employee:-");
            Console.WriteLine($"Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, FixedAmount: {this.FixedAmount}\n");
        }

    }
}