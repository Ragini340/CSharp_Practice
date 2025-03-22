namespace CSharp_Practice.ExceptionHandlings.Custom_Exception
{
    public class EmploymentForm
    {
        public static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("Enter the age:");
                age = int.Parse(Console.ReadLine());

                if (age > 35 || age <= 21)
                {
                    throw new EmploymentEligibilityException();
                }
                Console.WriteLine("Employment age " + age + " is valid.");
            }
            catch (EmploymentEligibilityException ex)  //If I comment this catch block then exception will be thrown from next catch
                                                      //block i.e. from super class Exception class and it will display same custom
                                                     //message which I have written.
                                                      
            {
                Console.WriteLine($"Error message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
            }
            
            Console.WriteLine("End of the Program");
        }

    }
}