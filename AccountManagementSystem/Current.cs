using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal class Current : Account
    {
        private decimal amount;

        internal override string Id
        {
            set { base.Id = "AC-" + value; }
        }

        internal decimal Amount
        {
            set { this.amount = value; }
            get { return this.amount; }
        }

        internal Current()
        {
        }

        internal Current(string name, string accType, Date openingDate, Address address, decimal balance) : base(name, accType, openingDate, address, balance)
        {
        }

        internal decimal Deposit(decimal amount)
        {
            if (this.Amount >= 500)
            {
                this.Amount = amount;

                Balance = Balance + this.Amount;
                return this.Amount;
            }
            else
            {
                return this.Balance = 0;
            }
        }

        internal decimal Withdraw(decimal Amount)
        {
            if (Amount <= Balance && Amount <= 5000)
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