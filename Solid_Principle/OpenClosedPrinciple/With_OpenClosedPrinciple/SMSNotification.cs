namespace CSharp_Practice.Solid_Principle.OpenClosedPrinciple.With_OpenClosedPrinciple
{
    //Open Closed Principle states that software entities(classes, modules, functions, etc.) should be open for extension,
    //but closed for modification, which means you should be able to extend a class behavior, without modifying it.
    public class SMSNotification : INotificationService
    {
        public void SendOTP(string medium)
        {
            //Write related logic
        }

        public void SendTransactionNotification(string medium)
        {
            //Write related logic
        }
    }
}
