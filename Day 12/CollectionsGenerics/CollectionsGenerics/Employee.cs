using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGenerics
{
    internal class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"id: {Id} name: {Name}";
        }
    }

    internal class EmployeeManager
    {
        List<Employee> employees = new List<Employee>();

        public void AddEmployee()
        {
            Console.Write("enter Employee Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("enter Employee name: ");
            string name = Console.ReadLine();

            Employee emp = new Employee(id, name);
            employees.Add(emp);
            Console.WriteLine("Added new Employee!");
        }

        public void displayEmployee()
        {
            if(employees.Count == 0)
            {
                Console.WriteLine("no employee to display!");
                return;
            } 

            foreach( Employee emp in employees)
            {
                emp.ToString();
            }

        }

        public void EditEmployee()
        {
            bool exist = false;
            Console.Write("enter Employee Id: ");
            int id = int.Parse(Console.ReadLine());

            foreach (Employee employee in employees)
            {
                if(employee.Id == id)
                {
                    Console.Write("Enter new name: ");
                    string newname = Console.ReadLine();

                    employee.Name = newname;
                    exist = true;
                }
            }

            if (!exist)
            {
                Console.WriteLine("Employee doesnot exist!");
            }
        }

        
    }
}
