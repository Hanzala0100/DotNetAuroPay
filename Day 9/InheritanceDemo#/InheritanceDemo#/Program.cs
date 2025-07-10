namespace InheritanceDemo_
{
    internal class Program
    {
        public static void TakeData(out int id, out string name, out string joinDate)
        {
            Console.Write("Enter id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter joining date: ");
            joinDate = Console.ReadLine();
        }
        public static void PrintEmployees(Employee[] employees)
        {
            Console.WriteLine("------------BONUS---------");
            foreach(Employee e in employees)
            {
                Console.WriteLine("Employee bonus: "+e.ShowBonus());
            }
        }

        //public static void DisplayMenu()
        //{
        //    int count = 0;
        //    Employee[] employees = new Employee[4];

        //    while(count < 4)
        //    {
        //        Console.WriteLine("Enter Your Choice");
        //        Console.Write("1. Permanent Employee 2. Contract Employee: ");
        //        if(int.TryParse(Console.ReadLine(), out int choice))
        //        {
        //            switch(choice)
        //            {
        //                case 1:
        //                    {
        //                        TakeData(out int id,out string name,out string date);
        //                        Console.Write("Enter Salary: ");
        //                        double salary = double.Parse(Console.ReadLine());

        //                        PermanentEmployee pEmp  = new PermanentEmployee(id, name, date, salary);
        //                        employees[count++] = pEmp;
        //                    }
        //                    break;
        //                case 2:
        //                    {
        //                        TakeData(out int id, out string name, out string date);
        //                        Console.Write("Enter Hours: ");
        //                        int hours = int.Parse(Console.ReadLine());
        //                        Console.Write("Enter wages: ");
        //                        double wages = double.Parse(Console.ReadLine());
        //                        ContractEmployee cEmp = new ContractEmployee(id, name, date, hours, wages);
        //                        employees[count++] = cEmp;
        //                    }
        //                    break;
        //                default: Console.WriteLine("Invalid Input!");
        //                    break;
        //            }
        //        }
        //    }

        public static void DisplayMenu()
        {
            EmployeeManager manager = new EmployeeManager();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Enter Your Choice");
                Console.Write("1. Add employee:  2. Display employee: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                TakeData(out int id, out string name, out string date);
                                Console.WriteLine("1. permanant 2. contract");

                                PermanentEmployee pEmp = new PermanentEmployee(id, name, date, salary);
                                manager.AddEmployee(pEmp);
                            }
                            break;
                        case 2:
                            {
                                TakeData(out int id, out string name, out string date);
                                Console.Write("Enter Hours: ");
                                int hours = int.Parse(Console.ReadLine());
                                Console.Write("Enter wages: ");
                                double wages = double.Parse(Console.ReadLine());
                                ContractEmployee cEmp = new ContractEmployee(id, name, date, hours, wages);
                                manager.AddEmployee(cEmp);
                            }
                            break;
                        default:
                            flag = false;
                            break;
                    }
                }
            }

            manager.displayBonuses();
        }
        static void Main(string[] args)
        {
            DisplayMenu();
        }
    }
}
