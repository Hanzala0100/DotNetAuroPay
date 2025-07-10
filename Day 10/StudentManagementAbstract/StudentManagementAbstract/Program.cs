namespace StudentManagementAbstract
{
    internal class Program
    {
        public static void DisplayMenu()
        {
            StudentManager studentManager = new StudentManager();
            
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("choose: ");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: studentManager.AddStudent();
                        break;
                    case 2: studentManager.ViewStudents();
                        break;
                    case 3: studentManager.UpdateStudent();
                        break;
                    case 4: studentManager.DeleteStudent();
                        break;
                    case 5: flag = false;
                        break;
                    default: Console.WriteLine("invalid input!");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            DisplayMenu();
        }
    }
}
