using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// Base class Account to hold the base methods
    /// and account balance
    /// </summary>
    class Account
    {
        //account balance
        private decimal accountBal;

        //Property for the account balance's getters and setters
        public decimal Balance
        {
            get { return accountBal; } //returns account balance
         
            set //sets the account balance. If the number is below 0 it throws an exception
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    accountBal = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n{0} is invalid due to being below 0. \n{1}, exception thrown\n", value, e);
                }
            }
        }

        //Basic constructor
        public Account()
        {
            accountBal = 0;
        }

        /// <summary>
        /// Constructor for Account that takes in the amount to make the
        /// account balance
        /// </summary>
        /// <param name="amount"></param>
        public Account(decimal amount)
        {
            this.Balance = amount;
        }

        /// <summary>
        /// Takes in an amount and adds that amount to the current account balance
        /// </summary>
        /// <param name="amount"></param>
        public virtual void Credit(decimal amount)
        {
            accountBal = accountBal + amount;
        }

        /// <summary>
        /// Takes in the amount being withdrawn and only withdraws that amount if it
        /// doesn't result in the account balance being below 0. It returns true when
        /// a transaction is successful and false if not.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual bool Debit(decimal amount)
        {
            if(accountBal - amount < 0)
            {
                Console.WriteLine("Debit amount exceeded account balance");
                return false;
            }
            else
            {
                accountBal = accountBal - amount;
                return true;
            }
        }
    }
}
