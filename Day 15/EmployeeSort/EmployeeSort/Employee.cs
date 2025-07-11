using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSort
{
    internal class Employee : IComparable<Employee>
    {
        string empName;
        int empId;
        double empSalary;


       

         public int CompareTo(Employee other)
        {
            return this.empId.CompareTo(other.empId);
        }



        public static int compareBySalary(Employee a, Employee b)
        {
            return a.EmpSalary.CompareTo(b.EmpSalary);
        }



        public Employee(string name, int id, double salary)
        {
            empName = name;
            empId = id;
            empSalary = salary;
        }
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public double EmpSalary
        {
            get { return empSalary; }
            set { empSalary = value; }
        }

       public override string ToString()
        {
            return $"Name: {empName}, ID: {empId}, Salary: {empSalary}";
        }

    }
       
       
}
