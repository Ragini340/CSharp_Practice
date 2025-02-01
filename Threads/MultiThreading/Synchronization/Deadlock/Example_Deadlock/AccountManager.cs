namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Deadlock.Example_Deadlock
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
            lock (FromAccount)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {FromAccount.Id}");
                Console.WriteLine($"{Thread.CurrentThread.Name} doing some work");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {ToAccount.Id}");
                lock (ToAccount)
                {
                    FromAccount.WithdrawMoney(TransferAmount);
                    ToAccount.DepositMoney(TransferAmount);
                }
            }
        }

    }
}