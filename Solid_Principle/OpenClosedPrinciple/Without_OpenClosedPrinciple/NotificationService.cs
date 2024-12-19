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

        //Lets's say in future we have requirement of send OTP via SMS or via Whatsapp, then we need to change code here using if else like below,
        //which violates closed for modification because here we are modifying code as per requirement:-

        /*public void SendOTP(String medium)
        {
            if (medium.Equals("Email"))
            {
                //Write related logic
            }
            else if (medium.Equals("SMS"))
            {
                //Write logic to send OTP via SMS
            }
            else if (medium.Equals("Whatsapp"))
            {
                //Write logic to send OTP via Whatsapp
            }
        }*/

    }
}
