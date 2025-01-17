namespace CSharp_Practice.Interface.Default_Method
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            IUPI upi = new PhonePay();
            upi.Pay();
            upi.CashBack();
         
            IUPI upi1 = new GooglePay();
            upi1.Pay();
            upi1.CashBack();

            IUPI upi2 = new PopClub();
            upi2.Pay();

            IUPIAdditional uPIAdditional = new Paytm();
            uPIAdditional.Pay();
            uPIAdditional.CashBack();
            uPIAdditional.ScratchCard();
        }
    }
}