using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BankAccount
    {
        public string AccountHolder {  get; set; }
        public double Balance { get; set; }

        public BankAccount(string name)
        {
            AccountHolder = name;

            //random starting balances
            Random rnd = new Random();
            Balance = 1000 + rnd.NextDouble()*100000;
        }

        public void WithDraw(double amount)
        {
            if(Balance < amount)
            {
                Console.WriteLine("The amount you want to withdraw is less than your Balance.");
                return;
            }

            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }




    }
}
