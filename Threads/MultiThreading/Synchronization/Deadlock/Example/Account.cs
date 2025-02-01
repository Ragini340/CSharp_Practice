namespace CSharp_Practice.Threads.MultiThreading.Synchronization.Deadlock.Example
{
    public class Account
    {
        public int Id { get; }
        private double Balance { get; set; }
        public Account(int id, double balance)
        {
            Id = id;
            Balance = balance;
        }

        public void WithdrawMoney(double amount)
        {
            Balance = Balance - amount;
        }

        public void DepositMoney(double amount)
        {
            Balance = Balance + amount;
        }

    }
}