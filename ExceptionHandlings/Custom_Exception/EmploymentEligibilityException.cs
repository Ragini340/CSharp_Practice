namespace CSharp_Practice.ExceptionHandlings.Custom_Exception
{
    public class EmploymentEligibilityException : Exception
    {
        public override string Message
        {
            get
            {
                return "Employement age should be greater than equal to 21 and less than 35.";
            }
        }

    }
}