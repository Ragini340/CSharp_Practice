namespace CSharp_Practice.OOPs.ClassAndObjects.PartialClass
{
    public partial class PartialEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public partial void PartialMethod(); //If we do not implement the partial method then it will throw compile time error as 
                                             //Partial method must have implementation part because it has accessbility modifiers.

        public partial void Test()
        {
            Console.WriteLine("Test method has been called");
        }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " Gender: " + Gender + " Salary: " + Salary;
        }
    }
}