using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    internal class Employee
    {
        public int EmpID {  get; set; }
        public string EmpName { get; set; }

        public double Salary {  get; set; }

        public Employee(int id,string name,double salary)
        {
            EmpID = id;
            EmpName = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"empId: {EmpID} name: {EmpName} salary: {Salary}";
        }
    }

    internal class EmployeeManager
    {
        Dictionary<int,Employee> employees = new Dictionary<int,Employee>();

        public void AddEmployee()
        {
            Console.Write("Emp id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Emp name: ");
            string name = Console.ReadLine();
            Console.Write("Emp salary: ");
            double salary = double.Parse(Console.ReadLine());

            Employee employee = new Employee(id,name,salary);

            employees.Add(id, employee);
            Console.WriteLine("Employee added sucessfully!");
        }

        public void display()
        {
            Console.WriteLine("--------EMPLOYEES----------");
            foreach(KeyValuePair<int,Employee> kvp in employees)
            {
                Console.WriteLine(kvp.Value);
            }
        }

        public void DisplayOne()
        {
            Console.Write("enter key to display: ");
            int id = int.Parse(Console.ReadLine());

            if (employees.ContainsKey(id))
            {
                Console.WriteLine(employees[id]);
            }
            else
            {
                Console.WriteLine("doesnot contain this id");
            }
        }

        public void FindAverageSalary()
        {
            double salarySum = 0;
            foreach(KeyValuePair<int, Employee> kv  in employees)
            {
                salarySum += kv.Value.Salary;
            }

            Console.WriteLine("the average salary is: " + (salarySum / employees.Count()));
        }
    }
}
