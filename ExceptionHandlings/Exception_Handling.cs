namespace CSharp_Practice.ExceptionHandlings
{
    public class Exception_Handling
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 1;

            try
            {
                int result = b / a;
            }
            catch (DivideByZeroException ex)
            {
                ex.HelpLink = "https://github.com/Ragini340";
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("HelpLink: " + ex.StackTrace);
                Console.WriteLine("Source: " + ex.Source);
                Console.WriteLine("StackTrace: " + ex.HelpLink);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
            /*catch (IndexOutOfRangeException ex) //Compile time error: A previous catch clause already catches all exceptions of this or
                                                 //of a super type ('type')
            {
                Console.WriteLine("Exception occurred" + ex);
            }
            catch (FileNotFoundException ex) //Compile time error: A previous catch clause already catches all exceptions of this or
                                            //of a super type ('type')
            {
                Console.WriteLine("Exception occurred" + ex);
            }*/
        }

    }
}