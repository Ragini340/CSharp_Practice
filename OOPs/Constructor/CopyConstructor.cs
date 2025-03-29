namespace CSharp_Practice.OOPs.Constructor
{
    public class CopyConstructor
    {
        private string month;
        private int year;

        //Copy constructor declaration
        public CopyConstructor(CopyConstructor copyConstructor)
        {
            month = copyConstructor.month;
            year = copyConstructor.year;
        }

        //Instace constructor
        public CopyConstructor(string month, int year)
        {
            this.month = month;
            this.year = year;
        }

        //Property
        public string Details
        {
            get
            {
                return "Month: " + month + "\nYear: " + year.ToString();
            }
        }

        public static void Main(string[] args)
        {
            CopyConstructor copyConstructor1 = new CopyConstructor("Aug", 2000);
            //Copying copyConstructor1 details copying to copyConstructor2
            CopyConstructor copyConstructor2 = new CopyConstructor(copyConstructor1);
            Console.WriteLine("CopyConstructor: ");
            Console.WriteLine(copyConstructor2.Details);
        }

    }
}