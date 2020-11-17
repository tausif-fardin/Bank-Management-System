using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal struct Date
    {
        private byte day, month;
        private ushort year;

        internal Date(byte day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        internal void ShowDate()
        {
            Console.WriteLine("Opening Date: {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }

    internal struct Address
    {
        private byte aptNo, roadNo;
        private string district, country;

        internal Address(byte aptNo, byte roadNo, string district, string country)
        {
            this.aptNo = aptNo;
            this.roadNo = roadNo;
            this.district = district;
            this.country = country;
        }

        internal void ShowAddress()
        {
            Console.WriteLine("Address: Apartment-{0},Road-{1},District-{2},Country-{3}", this.aptNo, this.roadNo, this.district, this.country);
        }
    }

    internal class Account
    {
        private static int serialNo = 1000;
        private string name, id, accType;
        private Date openingDate;
        private Address address;
        private decimal balance;

        internal string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        internal virtual string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        internal string AccType
        {
            set { this.accType = value; }
            get { return this.accType; }
        }

        internal Date OpeningDate
        {
            set { this.openingDate = value; }
            get { return this.openingDate; }
        }

        internal Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        internal decimal Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        internal Account()
        {
        }

        internal Account(string name, string accType, Date openingDate, Address address, decimal balance)
        {
            this.Name = name;
            this.Id = (++serialNo).ToString();
            this.AccType = accType;
            this.OpeningDate = openingDate;
            this.Address = address;
            this.Balance = balance;
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Account Information:");
            Console.WriteLine("Name:{0}", this.Name);
            Console.WriteLine("ID:{0}", this.Id);
            Console.WriteLine("Account Type:{0}", this.AccType);
            this.OpeningDate.ShowDate();
            this.Address.ShowAddress();
            Console.WriteLine("Balance:{0}", this.Balance);
        }
    }
}