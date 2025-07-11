namespace DictionaryDemo
{
    internal class Program
    {
        static void DisplayMenu()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            bool flag = true;
            while (flag)
            {
                Console.Write("1. Add 2.Display 3.DisplayOne 4.Average 5.Exit: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            employeeManager.AddEmployee();
                        }
                        break;
                    case 2:
                        {
                            employeeManager.display();
                        }
                        break;
                    case 3:
                        {
                            employeeManager.DisplayOne();
                        }
                        break;
                    case 4:
                        {
                            employeeManager.FindAverageSalary();
                        }
                        break;
                    case 5:
                        {
                            flag = false;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Wrong input!");
                        }
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            //Dictionary<int, string> dict = new Dictionary<int, string>();

            //dict.Add(1, "Youbraj");
            //dict.Add(2, "Manish");
            //dict.Add(3, "Edvin");

            //foreach (KeyValuePair<int, string> kvp in dict)
            //{
            //    Console.WriteLine($"key: {kvp.Key} value: {kvp.Value} object: {kvp}");
            //}

            DisplayMenu();
        }
    }
}
