using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal class Savings : Account
    {
        private decimal amount;

        internal decimal Amount
        {
            set { this.amount = value; }
            get { return this.amount; }
        }

        internal override string Id
        {
            set { base.Id = "AS-" + value; }
        }

        internal Savings()
        {
        }

        internal Savings(string name, string accType, Date openingDate, Address address, decimal balance) : base(name, accType, openingDate, address, balance)
        {
        }

        internal decimal Deposit(decimal amount)
        {
            this.Balance += amount;
            return this.Balance;
        }

        internal decimal Withdraw(decimal Amount)
        {
            if (this.Amount <= Balance && this.Amount <= 2000)
            {
                Balance = Balance - Amount;
                return this.Balance;
            }
            else
            {
                return this.Amount = 0;
            }
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}