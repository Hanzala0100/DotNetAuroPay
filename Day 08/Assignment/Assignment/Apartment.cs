using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Apartment :Meter
    {
        public string ApartmentNumber { get; set; }
        public int UnitsConsumed { get; set; }
        

        public Apartment()
        {
            Console.Write("Enter Apartment number: ");
            string ApartmentNumber = Console.ReadLine();
            Console.Write("Enter units consumed: ");
            int units = int.Parse(Console.ReadLine());

            this.ApartmentNumber = ApartmentNumber; 
            this.UnitsConsumed = units;
        }

        public void DisplayCurrentBill()
        {
            int billAmount = ElectricityBill(this.UnitsConsumed);
            DisplayCurrentRate();
            Console.WriteLine($"Bill for Apartment {this.ApartmentNumber} : {billAmount}Rs");
        }
    }

    internal class Society
    {
        Apartment[] apartments = new Apartment[3];
        static int count = 0;

        public void AddApartment()
        {
            if(count >= apartments.Length)
            {
                Console.WriteLine("Limit Reached");
                return;
            }

            Apartment apartment = new Apartment();
            apartments[count++] = apartment;
        }

        public void CheckBill()
        {
            Console.Write("Enter Apartment number: ");
            string ApartmentNumber = Console.ReadLine();

            bool exist = false;
            for(int i = 0; i < count; i++)
            {
                if (apartments[i].ApartmentNumber == ApartmentNumber)
                {
                    apartments[i].DisplayCurrentBill();
                    exist = true;
                }
            }

            if(!exist)
            {
                Console.WriteLine("the apartment does not exist!");
            }
        }

        public void ChangeRate()
        {
            Meter.ChangeCostPerUnit();
        }
    }
}
