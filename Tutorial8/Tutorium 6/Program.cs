using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account;

namespace Tutorium_6
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] accountList = new BankAccount[10];

            for (int index = 0; index < accountList.Length; ++index)
            {
                Console.WriteLine("Creating Savings Account for Client #{0, 2:D}", index + 1);

                accountList[index] = new SavingsAccount(index + 1);
            }

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Enter Deposit for Bankaccount {0}: ", i);
                decimal input = Convert.ToDecimal(Console.ReadLine());
                accountList[i].Deposit(input);
            }

            foreach (BankAccount account in accountList)
            {
                Console.WriteLine(account);
                Console.WriteLine(account.AccountBalance + "\n");
            }
        }
    }
}
