namespace Assignment
{
    internal class Program
    {
        public static void ChoiceFunction(string choice,BankAccount ba)
        {
            if(choice == "w" || choice == "W")
            {
                Console.Write("Amount to Withdraw : ");
                if(!int.TryParse(Console.ReadLine(), out int amount))
                {
                    Console.WriteLine("Invalid Input!");
                    return;
                }

                ba.Balance -= amount;
            }
            else if(choice == "d" ||  choice == "D")
            {
                Console.Write("Amount to Deposit : ");
                if (!int.TryParse(Console.ReadLine(), out int amount))
                {
                    Console.WriteLine("Invalid Input!");
                    return;
                }

                ba.Balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid Input!");
                return;
            }
        }
        public static void BankAccountGame()
        {
            BankAccount ba1 = new BankAccount("Youbraj");
            BankAccount ba2 = new BankAccount("Rohan");

            int rounds = 3;
            int currRound = 1;

            while(currRound <= rounds)
            {
                Console.WriteLine($"Round {currRound}: ");
                Console.Write("Account 1 Withdraw or Deposit (w/d): ");
                string? choice = Console.ReadLine();

                ChoiceFunction(choice, ba1);

                Console.Write("Account 2 Withdraw or Deposit (w/d): ");
                choice = Console.ReadLine();

                ChoiceFunction(choice,ba2);

                currRound++;
            }

            if (ba1.Balance > ba2.Balance)
                Console.WriteLine($"winner:{ba1.AccountHolder} Balance: {ba1.Balance}");
            else if (ba1.Balance < ba2.Balance)
                Console.WriteLine($"winner:{ba2.AccountHolder} Balance: {ba2.Balance}");
            else
                Console.WriteLine($"winner: Both have equal Balance.");
        }

        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Harry Potter";
            book1.Author = "J.K Rolling";
            book1.Price = 1000;
            book1.IsBestSeller = false;

            Book book2 = new Book();
            book2.Title = "Game of Thrones";
            book2.Author = "George RR Martin";
            book2.Price = 1500;
            book2.IsBestSeller = true;

            Console.WriteLine($"the price of the book {book1.Title}: {Book.CalculateDiscountedPrice(book1)}");
            Console.WriteLine($"the price of the book {book2.Title}: {Book.CalculateDiscountedPrice(book2)}");


            Rectangle rect1 = new Rectangle();

            Rectangle rect2 = new Rectangle(10,20);

            Console.WriteLine($"area of rect1: {rect1.GetArea()} is it square: {rect1.IsSquare()}");
            Console.WriteLine($"area of rect1: {rect2.GetArea()} is it square: {rect2.IsSquare()}");


            Console.WriteLine("10 + 20 = "+Calculator.Add(10,20));
            Console.WriteLine("10.05 + 20.23 = " + Calculator.Add(10.05, 20.23));
            int[] num = { 1, 2, 3, 4, 5 };
            int[] num1= { };
            Console.WriteLine("sum of {1,2,3,4,5}: " + Calculator.Add(num));
            Console.WriteLine("sum of {1,2,3,4,5}: " + Calculator.Add(num1));

            Student student1 = new Student("John Cena");
            Student student2 = new Student("Randy Orton",78);
            Student student3 = new Student("Cody Rhodes",99,'A');

            Student.AssignGrade(student1);
            Student.AssignGrade(student2);
            Student.AssignGrade(student3);

            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();

            //BankAccountGame();

            RemainingCodes.fibo(10);
            Console.WriteLine("");
            RemainingCodes.PrintSpacesNumber("hello this is a statement.");

            RemainingCodes.ReverseNumber(1221);

            RemainingCodes.Fees();
        }
    }
}
