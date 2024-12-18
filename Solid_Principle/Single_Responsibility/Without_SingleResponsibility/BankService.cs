using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.Solid_Principle.Single_Responsibility.Without_SingleResponsibility
{
    //Here the BankService class has multiple reasons to change
    public class BankService
    {
        public long Deposit(long amount, String accountNo)
        {
            //Deposit amount
            return 0;
        }

        public long Withdraw(long amount, String accountNo)
        {
            //Withdraw amount
            return 0;
        }

        public void PrintPassbook()
        {
           //Update transaction info in the passbook
        }

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

        public void SendOTP(String medium)
        {
            if (medium.Equals("Email"))
            {
                //Write related logic
            }
        }

    }
}
