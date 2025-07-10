using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicieRentalPrice
{
    abstract class Vehicle
    {
        public int Vehicle_Id {  get; set; }
        public string Brand {  get; set; }

        public void calculate_rental_rate(int days)
        {

        }
    }
}
