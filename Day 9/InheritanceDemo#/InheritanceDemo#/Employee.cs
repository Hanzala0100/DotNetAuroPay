using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo_
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JoinDate {  get; set; }

        public Employee(int id, string name, string joinDate)
        {
            Id = id;
            Name = name;
            JoinDate = joinDate;
        }

        public virtual double ShowBonus()
        {
            return 1000;
        }
    }

    class EmployeeManager
    {
        static int count = 0;
        Employee[] employees = new Employee[4];

        public void AddEmployee(Employee employee)
        {
            if(count == employees.Length)
            {
                Console.WriteLine("limit reached");
                return;
            }
            employees[count++] = employee; 
        }

        public void displayBonuses()
        {
            Console.WriteLine("------------BONUS---------");
            foreach (Employee e in employees)
            {
                Console.WriteLine("Employee bonus: " + e.ShowBonus());
            }
        }


    }
}
