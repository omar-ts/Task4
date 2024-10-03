using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Account account1 = new("Omar", 7000);
            Account account2 = new("Omar", 8000);
            Account account3 = new();
            account3 = account1 + account2;
            Console.WriteLine(account3.Balance);
            Account savingaccount = new SavingAccount("Ahmed", 5000, 0.05);
            Account checkaccount = new CheckingAccount("Malak", 200);
            checkaccount.Withdraw(100);
            Console.WriteLine(checkaccount.Balance);
            Account trustAccount = new TrustAccount("Omar", 1000, 1.05);
            trustAccount.Withdraw(200);
            trustAccount.Withdraw(200);
            trustAccount.Withdraw(200);
            trustAccount.Withdraw(200);
        }
    }
}
