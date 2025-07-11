using MyClassLibrary;

namespace ClassesAdvanced
{

    static class Globals
    {
        public static string collegeName = "LTCE";
        public static string collegeAddress = "koparkhairne";
        static Globals()
        {
            Console.WriteLine("static Constructor is called");
        }
    }
    internal class Program
    {

        static void DisplayMenu()
        {
            StudentManager studentManager = new StudentManager();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Welcome to the menu");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Student");
                Console.WriteLine("3. Edit Student");
                Console.WriteLine("4. Check Student");
                Console.WriteLine("5. exit");

                int.TryParse(Console.ReadLine(),out int choice);

                switch (choice)
                {
                    case 1:studentManager.AddStudent();
                        break;

                    case 2:studentManager.DisplayStudent();
                        break;

                    case 3:studentManager.EditStudent();
                        break;
                    case 4:
                        {
                            studentManager.CheckStudent();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Thanks for joining");
                            flag = false;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid output");
                        }
                        break;

                }

            }
        }
        static void Main(string[] args)
        {
            Student st = new Student(101,"Youbraj Singh","youbrajsingh@gmail.com",21);

            Console.WriteLine(st.ToString());

            DisplayMenu();
        }
    }
}
