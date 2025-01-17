namespace CSharp_Practice.Interface.Default_Method
{
    public class GooglePay : IUPI
    {
        public void Pay()
        {
            Console.WriteLine("Payment logic of GooglePay");
        }

       /*public static void Main(string[] args)
        {
            IUPI upi = new GooglePay();
            upi.CashBack();
        }*/
    }
}