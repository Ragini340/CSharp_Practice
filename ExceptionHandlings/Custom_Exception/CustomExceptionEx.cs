namespace CSharp_Practice.ExceptionHandlings.Custom_Exception
{
    public class CustomExceptionEx : Exception
    {
        public CustomExceptionEx(string message) 
        { 
            throw new Exception(message); 
        }

        public static void Divide(int a, int b)
        {
            try
            {
                Calculator cal = new Calculator();
                cal.Divide(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("10 / 2 result is:- ");
            Divide(10, 2);
            Console.WriteLine("\n10 / 0 result is:- ");
            Divide(10, 0);
            Console.WriteLine("\n100000 / 33 result is:- ");
            Divide(100000, 33);
        }
    }

    public class Calculator
    {
        public void Divide(int Numerator, int Denominator)
        {
            if (Denominator == 0)
            {
                throw new DivideByZeroException();
            }
            if (Numerator > 1000)
            {
                throw new CustomExceptionEx("Custom exception occurred as the numerator is greater than 1000.");
            }
            Console.WriteLine(Numerator / Denominator);
        }

    }
}