using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    internal class CreditCard :IPayment
    {
        //1234 1234 1234 1234 typically 16 digit long
        public string CardNumber {  get; set; }
        public int Balance { get; set; } = 10000;


        public CreditCard(string CreditCardNumber,string expiry)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.Year.GetType());
            string pattern = @"^[0-9]{16}$";
            if(Regex.IsMatch(CreditCardNumber, pattern))
            {
                DateTime expiryDate = DateTime.Parse(expiry);
                if(expiryDate < today)
                {
                    Console.WriteLine($"Credit card is expired! {expiryDate} and today is {today}");
                    return;
                }
                
                Console.WriteLine("Credit Card is ok and not expired");

            }
            else
                Console.WriteLine("invalid Credit Card!");
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
