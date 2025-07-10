using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    internal class DebitCard : IPayment
    {
        public string CardNumber { get; set; }
        public int Balance { get; set; } = 10000;


        public DebitCard(string DebitCarNumber, string expiry)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.Year.GetType());
            string pattern = @"^[0-9]{16}$";
            if (Regex.IsMatch(DebitCarNumber, pattern))
            {
                DateTime expiryDate = DateTime.Parse(expiry);
                if (expiryDate < today)
                {
                    Console.WriteLine($"Debit card is expired! {expiryDate} and today is {today}");
                    return;
                }

                Console.WriteLine("Debit Card is ok and not expired");

            }
            else
                Console.WriteLine("invalid Debit Card!");
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
