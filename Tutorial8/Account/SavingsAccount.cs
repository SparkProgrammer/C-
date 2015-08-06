using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class SavingsAccount : BankAccount
    {
        private decimal interestRate;

        /// <summary>
        /// The balance of this SavingsAccount
        /// </summary>
        public override decimal AccountBalance
        {
            get { return balance; }
        }

        public Decimal InterestRate
        {
            get
            {
                return interestRate;
            }
        }

        public SavingsAccount(int clientID, decimal rateOfInterest = 0.85M) : base(clientID)
        {
            if (rateOfInterest > 0.0M)
            {
                interestRate = rateOfInterest;
            }
        }

        public override void Deposit(decimal amount)
        {
            if (amount > 0.0M)
            {
                balance += amount;
            }
        }
        public override void WithDrawal(decimal amount)
        {
            if (amount > 0.0M && (AccountBalance - amount) >= 0.0M)
            {
                balance -= amount;
            }
        }
        public override string ToString()
        {
            return "Client Account #" + ClientID + " - Interest Rate " + InterestRate.ToString();
        }
        
    }
}
