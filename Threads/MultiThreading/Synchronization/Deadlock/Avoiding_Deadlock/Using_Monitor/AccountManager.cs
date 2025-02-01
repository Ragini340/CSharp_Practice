using CSharp_Practice.Threads.MultiThreading.Synchronization.Deadlock.Example_Deadlock;

namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Deadlock.Avoiding_Deadlock.Using_Monitor
{
    public class AccountManager
    {
        private Account FromAccount;
        private Account ToAccount;
        private double TransferAmount;

        public AccountManager(Account AccountFrom, Account AccountTo, double AmountTransfer)
        {
            FromAccount = AccountFrom;
            ToAccount = AccountTo;
            TransferAmount = AmountTransfer;
        }

        public void FundTransfer()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {FromAccount.Id}");

            if (Monitor.TryEnter(ToAccount, 300000000))
            {
                lock (FromAccount)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {FromAccount.Id}");
                    Console.WriteLine($"{Thread.CurrentThread.Name} doing some work");
                    //Thread.Sleep(3000);
                    Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {ToAccount.Id}");

                    Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {ToAccount.Id}");
                    try
                    {
                        FromAccount.WithdrawMoney(TransferAmount);
                        ToAccount.DepositMoney(TransferAmount);
                    }
                    finally
                    {
                        Monitor.Exit(ToAccount);
                    }
                }
            }
            else
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} unable to acquire lock on {ToAccount.Id}, so existing.");
            }
        }

    }
}