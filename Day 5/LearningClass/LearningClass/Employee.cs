using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClass
{
    public enum Designations { STAFF, MANAGER, PRESIDENT}
    internal class Employee
    {

        private int empId;
        private string empName;

        public static double salary = 30000;
        public Designations designation;

        public int EmpId { get { return empId; } set { empId = value; } }
        public string EmpName { get { return empName; } set { empName = value; } }

        public Employee() { }

        public Employee (int id, string name, Designations designation)
        {
            empId = id; empName = name; this.designation = designation;
        }

        public Employee (Employee obj)
        {
            this.EmpId = obj.EmpId;
            this.EmpName = obj.EmpName;
        }

        public void SalaryDistribution()
        {
            double HRA = salary * 0.1;
            double allowances = 10000;
            double basicSalary = salary - allowances - HRA;

            Console.WriteLine($"Basic salary: {basicSalary:c} allowances: {allowances:c} HRA: {HRA:c}");
            Console.WriteLine("Basic salary: {0:c} allowances: {1:c} HRA: {2:c}", basicSalary, allowances, HRA);
        }


        public static void CheckBonus(Employee obj)
        {
            if(obj.designation == Designations.STAFF)
            {
                Console.WriteLine("Bonus: " + 5000);
            }
            else if(obj.designation == Designations.MANAGER)
            {
                Console.WriteLine("Bonus: " + 10000);
            }
            else
            {
                Console.WriteLine("Bonus: "+ 0);
            }
        }
        public override string ToString()
        {
            string str = $"emp ID:{empId} emp NAME: {empName} emp SALARY: {salary}  designation: {designation}";
            return str;
        }
    }
}
