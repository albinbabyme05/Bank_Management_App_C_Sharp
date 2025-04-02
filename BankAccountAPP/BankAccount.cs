using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountAPP
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get;  set; }

        //Creating a constructor
        public BankAccount(string userName)
        {
            Owner = userName;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }
    }
}
