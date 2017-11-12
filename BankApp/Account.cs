using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    /// <summary>
    /// This is about a bank
    /// account
    /// </summary>
    class Account
    {
        #region Properties
        //this is a single line comment
        /*
         * 
         * 
         * */
        
        public int AccountNumber { get; private set; }
        public string EmailAddress { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; private set; }
        #endregion

        
        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary
        /// <param name="amount">Amount to be deposited</param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdrow(decimal amount)
        {
            Balance -= amount;
        }


        #endregion



    }
}
