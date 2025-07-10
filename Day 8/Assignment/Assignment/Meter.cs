using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Meter
    {
        public static int CostPerUnit = 10;//10Rs

        public int ElectricityBill(int units)
        {
            int bill = units * CostPerUnit;
            return bill;
        }

        public static void ChangeCostPerUnit()
        {
            Console.Write("Enter the new cost: ");
            if((int.TryParse(Console.ReadLine(), out int newCost)))
            {
                CostPerUnit = newCost;
            }
        }

        public static void DisplayCurrentRate()
        {
            Console.WriteLine($"The Current Rate: {CostPerUnit}Rs");
        }


    }
}
