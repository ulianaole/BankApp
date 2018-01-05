using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    static class Bank
    {
        private static BankModel db = new BankModel();     

        public static Account CreateAccount(string emailAddress, 
            string accountName = "Default Account",
            TypeOfAccount accountType = TypeOfAccount.Checking)
        {
            var account = new Account
            {
                EmailAddress = emailAddress,
                AccountName = accountName,
                AccountType = accountType
            };
            db.Accounts.Add(account);
            db.SaveChanges();

            
            return account;
        }
        public static List<Account> GetAllAccounts(string emailAddress)
        {
            return db.Accounts.Where(a => a.EmailAddress == emailAddress).ToList();
        } 

        public static void Deposit(int accountNumber, decimal amount)
        {
           var account = db.Accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault();
           if (account != null)
            {
                account.Deposit(amount); 
            }
        }
    }
}
