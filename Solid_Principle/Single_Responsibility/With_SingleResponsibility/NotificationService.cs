using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.Single_Responsibility.With_SingleResponsibility
{
    //NotificationService class has single responsibility to perform its task 
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
