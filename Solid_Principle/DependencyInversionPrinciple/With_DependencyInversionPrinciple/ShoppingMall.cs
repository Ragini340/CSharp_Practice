namespace CSharp_Practice.Solid_Principle.DependencyInversionPrinciple.With_DependencyInversionPrinciple
{
    //Shopping mall is loosely coupled with BankCard, any type of card processes the payment without any impact,
    //which is the Dependency Inversion Principle.
    public class ShoppingMall
    {
        private IBankCard bankCard;

        public ShoppingMall(IBankCard bankCard) //Constructor injection
        {
            this.bankCard = bankCard;
        }

        public void DoPayment(Object order, int amount)
        {
            bankCard.DoTransaction(amount);
        }

        public static void Main(String[] args)
        {
            IBankCard bankCard = new CreditCard();
            ShoppingMall shoppingMall = new ShoppingMall(bankCard);
            shoppingMall.DoPayment("Some orders", 400);
        }

    }
}
