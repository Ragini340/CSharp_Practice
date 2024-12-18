using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.InterfaceSegregationPrinciple.Without_InterfaceSegregationPrinciple
{
    public interface UPIPayments
    {
        public void PayMoney();

        public void GetScratchCard();

        public void GetCashBackAsCreditBalance();
    }
}
