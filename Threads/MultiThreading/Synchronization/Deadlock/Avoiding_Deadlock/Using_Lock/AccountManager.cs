using CSharp_Practice.Threads.MultiThreading.Synchronization.Deadlock.Example_Deadlock;

namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Deadlock.Avoiding_Deadlock.Using_Lock
{
    public class AccountManager
    {
        private Account FromAccount;
        private Account ToAccount;
        private readonly double TransferAmount;
        private static readonly Mutex mutex = new Mutex();

        public AccountManager(Account AccountFrom, Account AccountTo, double AmountTransfer)
        {
            this.FromAccount = AccountFrom;
            this.ToAccount = AccountTo;
            this.TransferAmount = AmountTransfer;
        }

        public void FundTransfer()
        {
            object _lock1, _lock2;
            if (FromAccount.Id < ToAccount.Id)
            {
                _lock1 = FromAccount;
                _lock2 = ToAccount;
            }
            else
            {
                _lock1 = ToAccount;
                _lock2 = FromAccount;
            }

            Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {((Account)_lock1).Id}");
            lock (_lock1)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {((Account)_lock1).Id}");
                Console.WriteLine($"{Thread.CurrentThread.Name} doing some work");
                Thread.Sleep(3000);
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {((Account)_lock2).Id}");
                lock (_lock2)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {((Account)_lock2).Id}");
                    FromAccount.WithdrawMoney(TransferAmount);
                    ToAccount.DepositMoney(TransferAmount);
                }
                Console.WriteLine($"{Thread.CurrentThread.Name} released lock on {((Account)_lock2).Id}"); 
                Console.WriteLine($"{Thread.CurrentThread.Name} released lock on {((Account)_lock1).Id}");
            }
        }

    }
}