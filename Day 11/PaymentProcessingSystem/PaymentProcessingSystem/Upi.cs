using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    internal class Upi:IPayment
    {
        public string UpiID {  get; set; }
        public int Balance { get; set; } = 10000;
        public Upi(string upiID)
        {
            //possible string youbrajsingh2576 @ok icici
            string pattern = @"^[A-Za-z0-9]+@ok(icici|hdfc)$";
            if (Regex.IsMatch(upiID, pattern))
                Console.WriteLine("upi id is ok");
            else
                Console.WriteLine("invalid upiID!");
        }

        public void DoPayment()
        {
            Console.Write("enter the Payment amount: ");
            int amount = int.Parse(Console.ReadLine());
            if(Balance < amount)
            {
                Console.WriteLine("Insufficient Balance!");
                return;
            }
            
            Balance -= amount;
            Console.WriteLine("Payment Successfull!");
        }

        public void ShowBalance()
        {
            Console.WriteLine("Current Balance: "+Balance);
        }




    }
}
