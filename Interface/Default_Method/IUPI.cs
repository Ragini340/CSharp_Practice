namespace CSharp_Practice.Interface.Default_Method
{
    public interface IUPI
    {
        /*CashBack method is non-static.
        private, internal, protected modifiers are not possible with Default method of interface.
        public, sealed, virtual are possible.
        By deafult Default methods of interface are virtual*/
        public void CashBack()  //Cashback feature is not possible in PopClub, so we are defining default interface method CashBack, 
                                //so that while implementing IUPI interface in PopClub class we do not need to call CashBack method.
        {
            Console.WriteLine("Cashback feature available");
        }

        public abstract void Pay();

        public void DBConnectionString()
        {
            //Write logic for DB connection string and use in all the classes which are implementing this interface throughout the
            //project
        }
    }
}