using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice.OOPs.Abstraction.AbstractionUsingInterface;

namespace CSharp_Practice.OOPs.Abstraction.UsingAbstractClassAndAbstractMethods
{
    public class DriverClass
    {
        public static void Main(string[] args)
        {
            Bank bank = FactoryBank.GetBankDetail("SBI Bank");
            bank.UpdateBalance();
            bank.CheckBalance();
            bank.CheckStatement();
        }
    }
}
