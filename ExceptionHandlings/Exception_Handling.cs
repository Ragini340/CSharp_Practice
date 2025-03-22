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
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception occurred" + ex);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Exception occurred" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}