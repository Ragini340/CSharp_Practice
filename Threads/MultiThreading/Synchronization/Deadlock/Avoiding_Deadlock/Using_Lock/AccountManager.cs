using CSharp_Practice.Threads.MultiThreading.Synchronization.Deadlock.Example_Deadlock;

namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Deadlock.Avoiding_Deadlock.Using_Lock
{
    public class AccountManager
    {
        private Account FromAccount;
        private Account ToAccount;
        private readonly double TransferAmount;

        public AccountManager(Account AccountFrom, Account AccountTo, double AmountTransfer)
        {
            this.FromAccount = AccountFrom;
            this.ToAccount = AccountTo;
            this.TransferAmount = AmountTransfer;
        }

        public void FundTransfer()
        {
            object _lock1 = FromAccount;
            object _lock2 = ToAccount;

            Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {((Account)_lock1).Id}");
            lock (FromAccount)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {((Account)_lock1).Id}");
                Console.WriteLine($"{Thread.CurrentThread.Name} doing some work");
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {((Account)_lock2).Id}");
                lock (ToAccount)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {((Account)_lock2).Id}");
                    FromAccount.WithdrawMoney(TransferAmount);
                    ToAccount.DepositMoney(TransferAmount);
                }
            }
        }

    }
}