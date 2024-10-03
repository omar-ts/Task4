namespace demo
{
    class TrustAccount : SavingAccount
    {
        int count = 3;
        public TrustAccount(string name, double balance, double intrate) : base(name, balance, intrate)
        {

        }
        public override bool Deposit(double amount)
        {
            if (amount > 0 && amount > 5000)
            {
                Balance = Balance + amount + 50;
                return true;
            }
            else if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }
        public override bool Withdraw(double amount)
        {
            double rule = Balance - (Balance * 0.20);
            if (Balance - amount > 0 && amount < rule && count > 0)
            {
                Balance -= amount;
                count = count - 1;
                Console.WriteLine($"Total balance is {Balance}");
                return true;
            }
            else if (count == 0)
            {
                Console.WriteLine($"You cannot withdarw any money till {DateTime.Now.AddYears(1)} and your balance is {Balance}");
                return true;
            }
            Console.WriteLine($"You cannot withdraw an amount greater than 20% of your balance and your balance is {Balance}");
            return false;
        }
    }
}
