using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.InterfaceSegregationPrinciple.Without_InterfaceSegregationPrinciple
{
    public class Paytm : UPIPayments
    {
        public void GetCashBackAsCreditBalance()
        {
            //Paytm doesn’t support GetCashBackAsCreditBalance() feature,
            //so here we shouldn’t force client paytm to override this method by implementating UPIPayments .
        }

        public void GetScratchCard()
        {
          //Write logic
        }

        public void PayMoney()
        {
           //Write Logic
        }

    }
}
