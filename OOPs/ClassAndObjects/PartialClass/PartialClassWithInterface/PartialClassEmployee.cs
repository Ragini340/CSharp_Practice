namespace CSharp_Practice.OOPs.ClassAndObjects.PartialClass.PartialClassWithInterface
{
    public partial class PartialClass : IEmployee
    {
        public void EmployeeMethod()
        {
            Console.WriteLine("Employee method has been called");
        }
    }
}
