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
        public partial void PartialMethod()  //If we do not declare the PartialMethod in another partial class then compiler will
                                             //throw compile time error: No defining declaration found for implementing declaration of
                                             //PartialMethod
        {
            Console.WriteLine("\nPartial method has been called");
        }

        public partial void Test();
       
        public void PublicMethod()
        {
            Console.WriteLine("\nPublic method has been called");
        }
    }
}
