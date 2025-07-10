using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{


    internal class Customer
    {
        public static int customerCount;

        public Customer()
        {
            customerCount++;
            StakeHolder.stakeHolderCount++;
        }
    }
}
