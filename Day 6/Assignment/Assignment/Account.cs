using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    public enum BankAccountType { SAVINGS, CURRENT }
    internal class Account
    {
        public string AccountNumber {  get; set; }
        public string AccountName { get; set; }
        public int Balance { get; set; }
        public BankAccountType AccountType { get; set; } = BankAccountType.SAVINGS;

        public Account(string name,int balance , string type)
        {
            Random rnd = new Random();
            int random = rnd.Next(1000000, 100000000);
            AccountNumber = "ICIC" + random.ToString();
            Balance = balance;
            AccountName = name;
            if(type == "savings") AccountType = BankAccountType.SAVINGS;
            else AccountType = BankAccountType.SAVINGS;

            Console.WriteLine("Your account number: " + AccountNumber);
        }

        public void ViewBalance()
        {
            Console.WriteLine("Balance: "+Balance);
        }

        public void Deposit(int amount)
        {
            Balance += amount;
            ViewBalance();
        }

        public void WithDraw(int amount)
        {
            if (Balance != 0)
            {
                Balance -= amount;
                ViewBalance();
            }
        }
    }

    internal class AccountManager
    {
        static int count = 0;
        Account[] accounts = new Account[3];
        public void AddAccount()
        {
            if(count >= accounts.Length)
            {
                Console.WriteLine("limit reached!");
            }

            Console.Write("enter AccountHolder name: ");
            string name = Console.ReadLine();
            Console.Write("enter Account type: ");
            string type = Console.ReadLine();
            Console.Write("enter Balance: ");
            int balance = int.Parse(Console.ReadLine());
            Account account = new Account(name,balance,type);
            accounts[count++] = account;
        }

        public void ViewBalance()
        {
            Console.Write("Enter Ac number: ");
            string acNumber = Console.ReadLine();

            int countnum = 0;
            for(int i = 0; i < count; i++)
            {
                if (accounts[i] != null && accounts[i].AccountNumber == acNumber)
                {
                    accounts[i].ViewBalance();
                }
                else
                {
                    count++;
                }
            }

            if(count == countnum)
            {
                Console.WriteLine("account Doesnot Exist!");
            }
        }

        public void Deposit()
        {
            Console.Write("Enter Ac number: ");
            string acNumber = Console.ReadLine();

            int countnum = 0;
            for (int i = 0; i < count; i++)
            {
                if (accounts[i] != null && accounts[i].AccountNumber == acNumber)
                {
                    Console.Write("Amount to deposit: ");
                    int.TryParse(Console.ReadLine(), out int amount);

                    accounts[i].Deposit(amount);
                }
                else
                {
                    count++;
                }
            }

            if (count == countnum)
            {
                Console.WriteLine("account Doesnot Exist!");
            }
        }

        public void Withdraw()
        {
            Console.Write("Enter Ac number: ");
            string acNumber = Console.ReadLine();

            int countnum = 0;
            for (int i = 0; i < count; i++)
            {
                if (accounts[i] != null && accounts[i].AccountNumber == acNumber)
                {
                    Console.Write("Amount to withdraw: ");
                    int.TryParse(Console.ReadLine(), out int amount);

                    accounts[i].WithDraw(amount);
                }
                else
                {
                    count++;
                }
            }

            if (count == countnum)
            {
                Console.WriteLine("account Doesnot Exist!");
            }
        }
    }
}
