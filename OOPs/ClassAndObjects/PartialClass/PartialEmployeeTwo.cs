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
    }
}
