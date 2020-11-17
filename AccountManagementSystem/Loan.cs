using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal class Loan : Account
    {
        private decimal amount;

        internal override string Id
        {
            set { base.Id = "AL-" + value; }
        }

        internal decimal Amount
        {
            set { this.amount = value; }
            get { return this.amount; }
        }

        internal Loan()
        {
        }

        internal Loan(string name, string accType, Date openingDate, Address address, decimal balance) : base(name, accType, openingDate, address, balance)
        {
        }

        internal decimal Deposit(decimal amount)
        {
            this.Amount = amount;
            Balance = Balance + this.Amount;
            return this.Balance;
        }

        internal decimal Withdraw(decimal Amount)
        {
            if ((Amount + 50) <= Balance)
            {
                Balance = Balance - Amount;
                Balance = Balance - 50;
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