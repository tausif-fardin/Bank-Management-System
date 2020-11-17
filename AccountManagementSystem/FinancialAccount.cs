using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal static class FinancialAccount
    {
        private static Account acc1 = new Savings("Tausif", "Savings", new Date(12, 10, 2018), new Address(12, 07, "Cox's Bazar", "Bangladesh"), 250000);
        private static Account acc2 = new Savings("Kelvin", "Savings", new Date(09, 09, 2018), new Address(12, 07, "Khulna", "Bangladesh"), 200000);
        private static Account acc3 = new Loan("Bob", "Loan", new Date(10, 09, 2019), new Address(11, 07, "Dhaka", "Bangladesh"), 100000);
        private static Account acc4 = new Loan("Bob", "Loan", new Date(11, 10, 2019), new Address(11, 07, "Dhaka", "Bangladesh"), 150000);
        private static Account acc5 = new Current("Zozo", "Current", new Date(15, 08, 2017), new Address(13, 07, "Chittagong", "Bangladesh"), 300000);
        private static Account acc6 = new Current("Victor", "Current", new Date(14, 05, 2017), new Address(13, 07, "Cox's Bazar", "Bangladesh"), 350000);

        private static Account a = new Account();
        private static Savings s = new Savings();
        private static Loan l = new Loan();
        private static Current c = new Current();

        private static Account[] account = new Account[2000];
        private static int count = 0;

        internal static void AddAccount(Account a)
        {
            account[count] = a;
            count++;
        }

        internal static void ShowAllAccount()
        {
            int i = 0;
            while (i < count)
            {
                while (account[i] == null)
                {
                    i++;
                }
                account[i].ShowInfo();
                i++;
            }
        }

        internal static bool SearchAccount(string key, out int i)
        {
            int index = 0;
            bool found = false;
            i = -1;
            while (index < count)
            {
                if (account[index].Id == key)
                {
                    Console.WriteLine("Account Found");
                    account[index].ShowInfo();
                    found = true;
                    i = index;
                    return found;
                }
                index++;
            }
            if (!found)
                Console.WriteLine("Account Not Found");

            return found;
        }

        internal static bool GetType(string key, out int i)
        {
            int index = 0;
            bool found = false;
            i = -1;
            while (index < count)
            {
                if (account[index].AccType == key)
                {
                    Console.WriteLine("Account Found");
                    account[index].ShowInfo();
                    found = true;
                    i = index;
                    return found;
                }
                index++;
            }
            if (!found)
                Console.WriteLine("Account Not Found");

            return found;
        }

        internal static void DeleteAccount(string key)
        {
            int index;
            bool decision = SearchAccount(key, out index);
            string name = account[index].Name;
            if (decision)
            {
                account[index] = null;
                Console.WriteLine(name + " has been deleted.");
            }
        }

        internal static void StartSystem()
        {
            while (true)
            {
                Console.WriteLine("1.Add Account.");
                Console.WriteLine("2.Search Account.");
                Console.WriteLine("3.Show All Account.");
                Console.WriteLine("4.Delete Account.");
                Console.WriteLine("5.Deposit.");
                Console.WriteLine("6.Withdraw.");
                Console.WriteLine("7.Transfer.");
                Console.WriteLine("8.Check Balance.");
                Console.WriteLine("9.Exit.");
                byte option = Convert.ToByte(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            AddAccount(acc1);
                            AddAccount(acc2);
                            AddAccount(acc3);
                            AddAccount(acc4);
                            AddAccount(acc5);
                            AddAccount(acc6);

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the account ID:");
                            string searchAccount = Console.ReadLine();
                            SearchAccount(searchAccount, out int j);
                            break;
                        }
                    case 3:
                        {
                            ShowAllAccount();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the account ID:");
                            string deleteAccount = Console.ReadLine();
                            DeleteAccount(deleteAccount);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter the account ID:");
                            string accID = Console.ReadLine();
                            bool decision = SearchAccount(accID, out int j);

                            if (decision)
                            {
                                if (account[j].AccType == "Savings")
                                {
                                    Console.WriteLine("Enter the amount:");
                                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                                    s.Deposit(amount);
                                    s.ShowInfo();
                                }
                                else if (account[j].AccType == "Current")
                                {
                                    Console.WriteLine("Enter the amount:");
                                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                                    c.Deposit(amount);
                                    c.ShowInfo();
                                }
                                else if (account[j].AccType == "Loan")
                                {
                                    Console.WriteLine("Enter the amount:");
                                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                                    l.Deposit(amount);
                                    l.ShowInfo();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Account Type.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Account Not Found.");
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Enter the account ID:");
                            string accID = Console.ReadLine();
                            bool decision = SearchAccount(accID, out int j);

                            if (decision)
                            {
                                if (account[j].AccType == "Savings")
                                {
                                    Console.WriteLine("Enter the amount:");
                                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                                    s.Withdraw(amount);
                                    s.ShowInfo();
                                }
                                else if (account[j].AccType == "Current")
                                {
                                    Console.WriteLine("Enter the amount:");
                                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                                    c.Withdraw(amount);
                                    c.ShowInfo();
                                }
                                else if (account[j].AccType == "Loan")
                                {
                                    Console.WriteLine("Enter the amount:");
                                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                                    l.Withdraw(amount);
                                    l.ShowInfo();
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Account Type.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Account Not Found.");
                            }
                            break;
                        }
                }
            }
        }
    }
}