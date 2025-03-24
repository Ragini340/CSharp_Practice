namespace CSharp_Practice.ExceptionHandlings
{
    public class ExceptionDepthConcept
    {
        public static int M1()
        {
            return M2();  //Exception has not been handled in M1() also, so it will throw the exception in the caller method Main().
        }

        public static int M2()
        {
            return M3();  //Exception has not been handled in M2() also, so it will throw the exception in the caller method M1().
        }

        public static int M3()
        {
            int a = 0, b = 1;
            int result = b / a;  //Exception has been occurred but not handled in this method, so it will throw in the caller method
                                 //M2().
            return result;
        }

        public static void Main(string[] args)
        {
            try             //Now exception has been handled in Main(), so catch block will handle the exception.
                            //If we do not handle the exception here then unhandled exception will occurr.
            {
                int result = M1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Handled exception: " + ex.Message);
            }

            Console.WriteLine("I am printing this line on Console because exception has been handled in the Main method, so it will be a normal execution after exception handled in the catch block.");
        }

    }
}