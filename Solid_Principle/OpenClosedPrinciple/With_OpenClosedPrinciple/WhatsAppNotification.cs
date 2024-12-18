using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.OpenClosedPrinciple.With_OpenClosedPrinciple
{
    //Open Closed Principle states that software entities(classes, modules, functions, etc.) should be open for extension,
    //but closed for modification, which means you should be able to extend a class behavior, without modifying it.
    public class WhatsAppNotification : NotificationService
    {
        public void SendOTP(string medium)
        {
           //Write logic here
        }

        public void SendTransactionNotification(string medium)
        {
           //Write logic here
        }
    }
}
