namespace demo
{
    class SavingAccount : Account
    {
        public double intrate { get; set; }
        public SavingAccount(string name, double balance, double intrate) : base(name, balance)
        {
            this.intrate = intrate;
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + intrate);
        }
    }
}
