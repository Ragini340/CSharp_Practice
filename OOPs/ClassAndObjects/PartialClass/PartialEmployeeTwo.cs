namespace CSharp_Practice.OOPs.ClassAndObjects.PartialClass
{
    public partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            Console.WriteLine($"Full name is:- {FirstName} {LastName}");
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("\nEmployee details are:-");
        }

        //Partial method
        public partial void PartialMethod()
        {
            Console.WriteLine("\nPartial method has been called");
        }

        public void PublicMethod()
        {
            Console.WriteLine("\nPublic method has been called");
        }
    }
}
