using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction.AbstractionUsingInterface
{
    public class SBI : IBank
    {
        public void CheckBalance()
        {
            Console.WriteLine("Balance");
        }

        public void CheckStatement()
        {
           Console.WriteLine("Statement");
        }

        public void ValidateCard()
        {
           Console.WriteLine("Validate card");
        }
    }
}
