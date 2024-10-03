namespace polymorphrism
{
    class CheckingAccount : Account
    {
        public double fee { get; set; }
        public CheckingAccount(string name = "omar", double balance = 200, double fee = 1.50) : base(name, balance)
        {
            this.fee = fee;
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + fee);
        }
    }
}
