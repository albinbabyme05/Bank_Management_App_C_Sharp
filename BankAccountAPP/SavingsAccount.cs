using BankApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountAPP
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        //create constructor for SavingsAccount Class
        /*when the SavingsAccount Constructor is initialized, the BankAccout Constructor also invoked that explained below code*/
        public SavingsAccount(string owner, decimal interestRate) : base(owner + "(S)")
        {
            InterestRate = interestRate;
        }

        public decimal CalcualteInterestRate(decimal amountToInterested)
        {
            return (amountToInterested * InterestRate) / 100;
            
        }

        public override string ValidateDeposit(decimal amount)
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
                decimal rate = CalcualteInterestRate(amount);
                Balance += amount + rate;
                return $"{amount} Euro Successfully Deposited";
            }
        }
    }
}
