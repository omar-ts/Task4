using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class CheckingAccount : Account
    {
        public double fee { get; set; }
        public CheckingAccount(string name, double balance, double fee=1.50):base(name,balance)
        {
            this.fee = fee;
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount+fee);
        }
    }
}
