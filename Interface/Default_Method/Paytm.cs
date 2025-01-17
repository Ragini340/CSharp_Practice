namespace CSharp_Practice.Interface.Default_Method
{
    public class Paytm : IUPIAdditional
    {
        public void Pay()
        {
            Console.WriteLine("Payment logic of Paytm");
        }

        public void ScratchCard()
        {
            Console.WriteLine("Get Scratchcard from Paytm");
        }
    }
}