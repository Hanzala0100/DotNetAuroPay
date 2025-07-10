using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    internal class Paypal : IPayment
    {
        //will make it work as NetBanking
        public string BankAccount {  get; set; }
        public int Balance { get; set; } = 10000;


        public Paypal(string bankAccount)
        {
            //12 digit only 
            string pattern = @"^[0-9]{12}$";
            if(Regex.IsMatch(bankAccount, pattern))
            {
                Console.WriteLine("bank account nukber is ok!");
            }
            else
            {
                Console.WriteLine("Bank account is wrong!");
            }
        }

        public void DoPayment()
        {
            Console.Write("enter the Payment amount: ");
            int amount = int.Parse(Console.ReadLine());
            if (Balance < amount)
            {
                Console.WriteLine("Insufficient Balance!");
                return;
            }

            Balance -= amount;
            Console.WriteLine("Payment Successfull!");
        }

        public void ShowBalance()
        {
            Console.WriteLine("Current Balance: " + Balance);
        }
    }
}
