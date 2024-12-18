using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.OpenClosedPrinciple.Without_OpenClosedPrinciple
{
    public class NotificationService
    {
        public void SendOTP(String medium)
        {
            if (medium.Equals("Email"))
            {
                //Write related logic
            }
        }
    }
}
