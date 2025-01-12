namespace CSharp_Practice.OOPs.ClassAndObjects.PartialClass.PartialClassWithInterface
{
    public partial class PartialClass : ICustomer
    {
        public void CustomerMethod()
        {
            Console.WriteLine("Customer method has been called");
        }
    }
}
