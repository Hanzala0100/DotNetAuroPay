using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee
    {
        private int empId;
        private string empName;

        public static string companyName = "AurionPro";
        public static int empCount;

        
        public Employee()
        {
            empCount++;
            StakeHolder.stakeHolderCount++;
        }
        public void EmpId(int id)
        {
            this.empId = id;
        }

        public void EmpName(string name)
        {
            this.empName = name;
        }

        public int EmpId()
        {
            return this.empId;
        }

        public string EmpName()
        {
            return this.empName;
        }
    }
}
