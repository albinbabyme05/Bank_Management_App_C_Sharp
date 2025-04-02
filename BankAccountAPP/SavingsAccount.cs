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
        public SavingsAccount(string owner, decimal interestRate) : base(owner)
        {
            InterestRate = interestRate;
        }

    }
}
