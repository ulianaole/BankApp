using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comment: reference, object, instance of a class
            var account = new Account
            {
                AccountName = "My checking",
                AccountType = TypeOfAccount.Checking,
                EmailAddress = "test@test.com"
            };


            account.Deposit(100.10M);
            Console.WriteLine($"Number:{account.AccountNumber}, EmailAddress:{account.EmailAddress}, Blanace:{account.Balance}, AccountType{account.AccountType}");

            var account2 = new Account
            {
                AccountName = "My savings",
                EmailAddress = "test2@test.com",
                AccountType = TypeOfAccount.Savings
            };
           

            account2.Deposit(100.10M);
            Console.WriteLine($"Number:{account2.AccountNumber}, EmailAddress:{account2.EmailAddress}, Blanace:{account2.Balance}, AccountType{account2.AccountType}");

        }



    }
}
