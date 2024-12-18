using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.Single_Responsibility.With_SingleResponsibility
{
    //LoanService class has single responsibility to perform its task 
    public class LoanService
    {
        public void GetLoanInterestInfo(String loanType)
        {
            if (loanType.Equals("Home Loan"))
            {
                //Do some job
            }
            if (loanType.Equals("Personal Loan"))
            {
                //Do some job
            }
            if (loanType.Equals("Car Loan"))
            {
                //Do some job
            }
        }

    }
}
