using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance { get; set; }

        public void Deposit (double amount)
        {
            balance = ((balance * 100) + (amount * 100)) / 100;
        }

        public double GetBalance ()
        {
            return balance;
        }
    }
}
