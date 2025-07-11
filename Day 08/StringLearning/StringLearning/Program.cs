using System.Text;

namespace StringLearning
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

    public struct Employee
    {
        public int Id;
        public string Name;
        public int Salary;
        public static int count;

        public Employee(int id,string name, int salary)
        {
            Console.WriteLine("parameterized constructor of struct");
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public Employee(int id, string name)
        {
            Console.WriteLine("other parameterized constructor of struct");
            this.Id = id;
            this.Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"display kero!\nid: {this.Id} name: {this.Name}");
        }

        public static void EmpCount()
        {
            count++;
        }


    }

    internal class Program
    {

        static void Add(int a , int b, int c = 30)
        {
            Console.WriteLine(a+b+c);
        }
        static void Main(string[] args)
        {
            char[] c = { 'a', 'b', 'c' };
            string str = new string(c);

            string str1 = "this is str1";

            string name = "Ganesh";

            string str3 = string.Concat(str, name);

            string new_name = name.Replace("esh", "apati");

            string sub = str1.Substring(0, 5);

            string str4 = "apple,banana,orange";
            string[] fruits = str4.Split(",");
            bool containsBanana = str4.Contains("banana");
            bool startWith = str4.StartsWith("apple");
            bool endsWith = str4.EndsWith("apple");


            Console.WriteLine("str:" + str);
            Console.WriteLine("str1:" + str1);
            Console.WriteLine("str3:" + str3);
            Console.WriteLine("name:" + name);
            Console.WriteLine("new_name:" + new_name);
            Console.WriteLine("sub:" + sub);
            Console.WriteLine("containsBanana: " + containsBanana);
            Console.WriteLine("startwith: " + startWith);
            Console.WriteLine("endsWith: " + endsWith);

            foreach(string fruit in fruits)
            {
                Console.Write(fruit+" ");
            }

            StringBuilder sb = new StringBuilder("\nnamaste! ");
            sb.Append("Hello");
            sb.Append(" World");

            Console.WriteLine(sb);

            Add(10, 20);
            Add(10, 20, 50);

            Console.WriteLine(Globals.collegeName);

            Employee employee = new Employee(101,"Youbraj");
            employee.Display();
            

        }
    }
}
