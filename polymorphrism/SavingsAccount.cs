namespace polymorphrism
{
    class SavingsAccount : Account
    {
        public double intrate { get; set; }
        public SavingsAccount(string name = "unknown name", double balance = 2, double intrate = 1.05) : base(name, balance)
        {
            this.intrate = intrate;
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + intrate);
        }
    }
}
