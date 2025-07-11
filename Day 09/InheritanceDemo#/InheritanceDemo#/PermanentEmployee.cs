using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo_
{
    internal class PermanentEmployee : Employee
    {
        public double Salary {  get; set; }

        public PermanentEmployee(int id, string name,string joinDate, double salary): base(id, name, joinDate)
        {
            Salary = salary;
        }

        public override double ShowBonus()
        {
            double bonus = base.ShowBonus();
            if(Salary >= 30000)
            {
                double extra = Salary * 0.10;
                bonus = base.ShowBonus() + extra; ;
            }

            return bonus;
        }
    }
}
