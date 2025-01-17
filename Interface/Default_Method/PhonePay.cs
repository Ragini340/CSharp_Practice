namespace CSharp_Practice.Interface.Default_Method
{
    public class PhonePay : IUPI
    {
        public void Pay()
        {
            Console.WriteLine("Payment logic of PhonePay");
        }
    }
}