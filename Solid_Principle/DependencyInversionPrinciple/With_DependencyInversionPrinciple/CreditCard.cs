namespace CSharp_Practice.Solid_Principle.DependencyInversionPrinciple.With_DependencyInversionPrinciple
{
    public class CreditCard : IBankCard
    {
        public void DoTransaction(int amount)
        {
            Console.WriteLine("Transaction done with CreditCard");
        }
    }
}
