using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// SavingAccount class that derives from the base class Account
    /// </summary>
    class SavingsAccount : Account
    {
        // The interest rate
        private decimal interest;

        /// <summary>
        /// Basic constructor for SavingsAccount that sets the balance and
        /// interest rate to 0
        /// </summary>
        public SavingsAccount()
        {
            this.Balance = 0;
            this.interest = 0;
        }

        /// <summary>
        /// Constructor that takes in amount and percent which are the
        /// account balance and interest rate respectfully. It then applies
        /// those numbers to the respective variables, using the property to
        /// assign the account balance.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="percent"></param>
        public SavingsAccount(decimal amount, decimal percent)
        {
            this.Balance = amount;
            this.interest = percent;
        }

        /// <summary>
        /// Calculates and returns the interest based on the account balance.
        /// </summary>
        /// <returns></returns>
        public decimal CalculateInterest()
        {
            return this.Balance * interest;
        }


    }
}
