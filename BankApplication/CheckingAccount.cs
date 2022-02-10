using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class CheckingAccount : Account
    {
        private decimal charge;

        /// <summary>
        /// Basic constructor for SavingsAccount that sets the balance and
        /// fee rate to 0
        /// </summary>
        public CheckingAccount()
        {
            this.Balance = 0;
            this.charge = 0;
        }

        /// <summary>
        /// Constructor that takes in amount and price which are the
        /// account balance and fee charge respectfully. It then applies
        /// those numbers to the respective variables, using the property to
        /// assign the account balance.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="price"></param>
        public CheckingAccount(decimal amount, decimal price)
        {
            this.Balance = amount;
            this.charge = price;
        }

        /// <summary>
        /// Overrides the original Credit method inherited from Account. It now
        /// also subtracts a fee from the account whenever a transaction is made.
        /// </summary>
        /// <param name="amount"></param>
        public override void Credit(decimal amount)
        {
            this.Balance = this.Balance + amount;
            this.Balance = this.Balance - charge;
        }

        /// <summary>
        /// Overrides the original Credit method inherited from Account. It now
        /// also subtracts a fee from the account whenever a transaction is 
        /// successfully made. It returns true when a transaction is successful 
        /// and false if not.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override bool Debit(decimal amount)
        {
            if (this.Balance - amount < 0 || this.Balance - (amount + charge) < 0)
            {
                Console.WriteLine("Debit amount exceeded account balance");
                return false;
            }
            else
            {
                this.Balance = this.Balance - amount;
                this.Balance = this.Balance - charge;
                return true;
            }
        }
    }
}
