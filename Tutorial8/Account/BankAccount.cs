using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account;

namespace Account
{
    public abstract class BankAccount
    {
        private int clientID; //Identifies the onwer of that Bank Account
        private String accountNumber;
        protected decimal balance;

        /// <summary>
        /// The ID for the Client who owns this Account
        /// </summary>
        public int ClientID
        {
            set
            {
                if (value >=1) 
                {
                    clientID=value;
                }
            }
            get
            {
                return clientID;
            }
        }
        /// <summary>
        /// The AccountNumber for this client
        /// </summary>
        public string AccountNumber
        {
            set
            {
                if (value.Length > 0)
                {
                    accountNumber = value;
                }
            }
            get
            {
                return accountNumber;
            }
        }
        /// <summary>
        /// An abstract property. Returns the balance for this account, though
        /// the details are left to derived classes to implement specific behavior.
        /// </summary>
        public abstract Decimal AccountBalance
        {
            get;
        }

        /// <summary>
        /// Constructs a BankAccount for the specified Client
        /// </summary>
        /// <param name="clientNumber"></param>
        public BankAccount(int clientNumber)
        {
            ClientID = clientNumber;
        }

        /// <summary>
        /// Deposit money into this Account; derived classes should override to
        /// provide specific behavior.
        /// </summary>
        /// <param name="amount"></param>
        /// 
        public abstract void Deposit(Decimal amount);
        /// <summary>
        /// Deposit money into this Account; derived classes should override to
        /// provide specific behavior.
        /// </summary>
        /// <param name="amount"></param>
        public abstract void WithDrawal(Decimal amount);

    }
}
