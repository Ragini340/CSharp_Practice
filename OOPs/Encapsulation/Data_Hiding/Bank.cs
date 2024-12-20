using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.OOPs.Encapsulation.Data_Hiding
{
    public class Bank
    {
        private double balance;

        public double GetBalance()
        {
            return balance;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
    }

    public class Driver
    {
        public static void Main()
        {
            Bank bank = new Bank();
            bank.SetBalance(100);
            Console.WriteLine("Balance is: " + bank.GetBalance());
        }
    }
}
