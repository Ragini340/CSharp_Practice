using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Abstraction.AbstractionUsingInterface
{
    public interface IBank
    {
        public void ValidateCard();
        public void CheckBalance();
        public void CheckStatement();
    }
}
