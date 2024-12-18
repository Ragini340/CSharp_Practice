using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.OpenClosedPrinciple.With_OpenClosedPrinciple
{
    public interface NotificationService
    {
        public void SendOTP(string medium);
        public void SendTransactionNotification(string medium);
    }
}
