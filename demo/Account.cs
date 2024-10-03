namespace demo
{
    class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
        public Account() { }
        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                Balance += amount;
                return true;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public static Account operator +(Account a, Account b)
        {
            Account account = new Account() { Balance = a.Balance + b.Balance };
            return account;
        }
    }
}
