using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        //Creating a constructor
        public BankAccount(string userName)
        {
            Owner = userName;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        public virtual string ValidateDeposit(decimal amount)
        {
            if (amount > 20000)
            {
                return "Deposit Limit reached. Please Contact BM.";
            }
            else if (amount <= 0)
            {
                return $"You can not deposit {amount} Euro";
            }
            else
            {
                Balance += amount;
                return $"{amount} Euro Successfully Deposited";
            }
        }

        public string Validatewithdraw(decimal amount)
        {
            if (amount > 5000)
            {
                return "Withdraw Limit reached. Please Contact BM.";
            }
            else if (amount <= 0)
            {
                return $"You can not withdrawed {amount} Euro";
            }
            else
            {
                if (Balance > amount)
                {
                    Balance -= amount;
                    return $"{amount} Euro Successfully Withdrawed \n Current Balance : {Balance}";
                }
                else
                {
                    return "Insuffecient Balance !!! ";
                }

            }
        }
    }
}
