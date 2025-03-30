namespace CSharp_Practice.OOPs.Encapsulation.Data_Hiding
{
    public class DataHidingUsingProperties
    {
        private double amount;

        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Please pass a positive value");
                }
                else
                {
                    amount = value;
                }
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                DataHidingUsingProperties dataHidingUsingProperties = new DataHidingUsingProperties();
                dataHidingUsingProperties.Amount = 100;
                Console.WriteLine(dataHidingUsingProperties.Amount);
                dataHidingUsingProperties.Amount = -20;
                Console.WriteLine(dataHidingUsingProperties.Amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}