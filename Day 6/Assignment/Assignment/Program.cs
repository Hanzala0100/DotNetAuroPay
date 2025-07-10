namespace Assignment
{
    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Id {  get; set; }
        public double Height { get; set; } = 5;
        public double Weight { get; set; } = 50;

        public double BMI()
        {
            double bmi = Weight/ (Height * Height);
            return bmi;
        }

        public void Bodytype()
        {
            if(BMI() < 18.5) Console.WriteLine("Underweight");
            if (BMI() >= 18.5 && BMI() <= 24.5) Console.WriteLine("Normal");
            if(BMI() >= 25) Console.WriteLine("Overweight");
        }
    }

    class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name,int age,string subject)
        {
            Name = name;
            Age = age;
            Subject = subject;
        }

        public override string ToString()
        {
            string str = $"name: {Name} age: {Age} subject: {Subject}";
            return str ;
        }
    }

    class Book(string title, int year, string author)
    {
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public int Year { get; set; } = year;

    }

    class BookLibrary
    {
        static int count = 0;
        Book[] books = new Book[5];
        public void AddBook()
        {
            if(count >= books.Length)
                Console.WriteLine("limit reached!");

            Console.Write("enter book title: ");
            string title = Console.ReadLine();
            Console.Write("enter book author: ");
            string author = Console.ReadLine();
            Console.Write("enter book age: ");
            int year = int.Parse(Console.ReadLine());
            Book book = new Book(title,year,author);
            books[count++] = book;
        }

        public void display()
        {
            foreach(Book book in books)
            {
                book?.ToString();
            }
        }
    }



    internal class Program
    {
        static void DisplayMenu()
        {
            AccountManager manager = new AccountManager();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the menu");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. View Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. exit");

                int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 1:
                        manager.AddAccount();
                        break;

                    case 2:
                        manager.ViewBalance();
                        break;

                    case 3:
                        manager.Deposit();
                        break;
                    case 4:
                        manager.Withdraw();
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
            EnumQuestions.Week(6);
            EnumQuestions.TrafficActions(TrafficLight.GREEN);
            EnumQuestions.GravityCalc(70);
            Remaining_codes.LargestOfThree(7, 5, 4);
            Remaining_codes.MultiplicationTable(8);

            Teacher t1 = new Teacher("youbraj", 21, "C#");
            Console.WriteLine(t1.ToString()); 

            Person p1 = new Person();
            p1.Name = "Youbraj";
            p1.Age = 21;
            p1.Weight = 90;
            p1.Height = 1.5;
            p1.Bodytype();

            DisplayMenu();
        }


    }
}
