using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo_
{
    internal class ContractEmployee : Employee
    {
        public int Hours {  get; set; }
        public double Wages {  get; set; }

        public ContractEmployee(int id, string name, string joinDate,int hours,double wages) : base(id, name, joinDate)
        {
            this.Hours = hours;
            this.Wages = wages;
        }

        public override double ShowBonus()
        {
            double bonus = base.ShowBonus();
            if(this.Hours > 100)
            {
                double paymemt = this.Hours * this.Wages;
                double extra = paymemt * 0.10;

                bonus = base.ShowBonus() + extra;
            }

            return bonus;
        }
    }
}
