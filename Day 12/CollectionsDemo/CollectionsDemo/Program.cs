using System.Collections;

namespace CollectionsDemo
{
    internal class Employee
    {
        public string EmpName { get; set; }
        public int EmpID { get; set; }
        public double Salary { get; set; }

        //public Employee(string empName, int empID, double salary)
        //{
        //    EmpName = empName;
        //    EmpID = empID;
        //    Salary = salary;
        //}

        public override string ToString()
        {
            return $"id: {EmpID} name: {EmpName} salary: {Salary}";
        }
    }

    internal class EmployeeManager
    {
        Hashtable Emp = new Hashtable();

        public void Add()
        {
            Console.Write("enter id of the employee: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("enter name of the employee: ");
            string name = Console.ReadLine();

            if (Emp.ContainsKey(id))
            {
                Console.WriteLine($"this employee already exists key: {id} name: {Emp[id]}");
                return;
            }

            Emp.Add(id, name);

            Console.WriteLine("employee added!");
        }

        public void Remove()
        {
            Console.Write("enter id of the employee to Remove: ");
            int id = int.Parse(Console.ReadLine());

            if(Emp.ContainsKey(id))
            {
                Emp.Remove(id);
                Console.WriteLine("The employee is removed");
            }
            else
            {
                Console.WriteLine("no employee with this id exists!");
            }
        }

        public void DisplayAll()
        {
            foreach( Object keys in Emp.Keys)
            {
                Console.WriteLine($"{keys} : {Emp[keys]}");
            }
        }
    }

        
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2.5);
            arrayList.Add('a');
            arrayList.Add("string");

            Employee employee = new Employee();
            employee.EmpName = "Youbraj";
            employee.EmpID = 1;
            employee.Salary = 33103;

            arrayList.Add(employee);

            foreach (Object obj in arrayList)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.WriteLine("the second element in the arryalist is " + arrayList[1]);

            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2.5);
            q.Enqueue('s');
            q.Enqueue("string");
            q.Enqueue(employee);
            q.Dequeue();


            //q.Peek();
            //Console.WriteLine(q.Peek());

            foreach (Object obj in q)
            {
                Console.WriteLine(obj is string);
            }

            Hashtable ht = new Hashtable();
            ht.Add(1, "youbraj");
            ht.Add(2, "Om");
            //ht.Add(1, "Edvin");

            foreach (Object keys in ht.Keys)
            {
                Console.WriteLine($"{keys} : {ht[keys]}");
            }


            EmployeeManager manager = new EmployeeManager();

            manager.Add();
            manager.Add();
            manager.Add();

            manager.DisplayAll();


        }
    }
}
