namespace CSharp_Practice.OOPs.Encapsulation.Data_Hiding
{
    public class BankDetailsUsingValidation
    {
        private int Amount;
        public int GetAmount()
        {
            return Amount;
        }

        //Since the private class members cannot change by the client, we can validate the data before storing it in the variable.
        public void SetAmount(int Amount)
        {
            if (Amount > 0)
            {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("Please enter a positive value");
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                BankDetailsUsingValidation bankDetailsUsingValidation = new BankDetailsUsingValidation();
                bankDetailsUsingValidation.SetAmount(100);
                Console.WriteLine(bankDetailsUsingValidation.GetAmount());
                bankDetailsUsingValidation.SetAmount(-100);
                Console.WriteLine(bankDetailsUsingValidation.GetAmount());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}