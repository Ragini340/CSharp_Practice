namespace CSharp_Practice.Solid_Principle.DependencyInversionPrinciple.With_DependencyInversionPrinciple
{
    public class DebitCard : IBankCard
    {
        public void DoTransaction(int amount)
        {
            Console.WriteLine("Transaction done with DebitCard");
        }
    }
}
