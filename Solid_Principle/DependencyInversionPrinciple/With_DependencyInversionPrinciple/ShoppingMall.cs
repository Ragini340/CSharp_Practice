using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.DependencyInversionPrinciple.With_DependencyInversionPrinciple
{
    //Shopping mall is loosely coupled with BankCard, any type of card processes the payment without any impact,
    //which is the Dependency Inversion Principle.
    public class ShoppingMall
    {
        private BankCard bankCard;

        public ShoppingMall(BankCard bankCard) //Constructor injection
        {
            this.bankCard = bankCard;
        }

        public void DoPayment(Object order, int amount)
        {
            bankCard.DoTransaction(amount);
        }

        public static void main(String[] args)
        {
            BankCard bankCard = new CreditCard();
            ShoppingMall shoppingMall = new ShoppingMall(bankCard);
            shoppingMall.DoPayment("Some orders", 400);
        }

    }
}
