using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.DependencyInversionPrinciple.Without_DependencyInversionPrinciple
{
    //Below is wrong design of coding, here ShoppingMall class is tightly coupled with DebitCard.
    //If we go with CreditCard then this won’t be possible because ShoppingMall is tightly couple with DebitCard.
    //We can do that by removing DebitCard from constructor and inject CreditCard, which is not a good approach to write code.
    public class ShoppingMall
    {
        private DebitCard debitCard;

        public ShoppingMall(DebitCard debitCard)
        {
            this.debitCard = debitCard;
        }

        public void DoPayment(Object order, int amount)
        {
            debitCard.DoTransaction(amount);
        }

        public static void main(String[] args)
        {
            DebitCard debitCard = new DebitCard();
            ShoppingMall shoppingMall = new ShoppingMall(debitCard);
            shoppingMall.DoPayment("some orders", 40000);
        }

    }
}
