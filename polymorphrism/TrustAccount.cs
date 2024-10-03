namespace polymorphrism
{
    class TrustAccount : SavingsAccount
    {
        int count = 3;
        public TrustAccount(string name = "Ahmed", double balance = 1000, double intrate = 2.05) : base(name, balance, intrate)
        {

        }
        public override bool Deposit(double amount)
        {
            if (amount > 0 && amount > 5000)
            {
                balance = balance + amount + 50;
                return true;
            }
            else if (amount > 0)
            {
                balance += amount;
                return true;
            }
            return false;
        }
        public override bool Withdraw(double amount)
        {
            double rule = balance - (balance * 0.20);
            if (balance - amount > 0 && amount < rule && count > 0)
            {
                balance -= amount;
                count = count - 1;
                Console.WriteLine($"Total balance is {balance}");
                return true;
            }
            else if (count == 0)
            {
                Console.WriteLine($"You cannot withdarw any money till {DateTime.Now.AddYears(1)} and your balance is {balance}");
                return true;
            }
            Console.WriteLine($"You cannot withdraw an amount greater than 20% of your balance and your balance is {balance}");
            return false;
        }
    }
}
