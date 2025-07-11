namespace SmartLibraryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library("City Library");
            myLibrary.AddBook(new Book(2, "Book Two", "Author B", "Non-Fiction"));
            myLibrary.AddBook(new Book(3, "Book Three", "Author C", "Science"));
            myLibrary.AddBook(new Book(1, "Book One", "Author A", "Fiction"));
            myLibrary.AddBook(new Book(1, "Book One", "Author A", "Fiction"));
            myLibrary.AddBook(new Book(4, "Book Four", "Author C", "Non-Fiction"));
            myLibrary.AddMember(new Member(1, "Alice"));
            myLibrary.AddMember(new Member(2, "Bob"));
            myLibrary.AddMember(new Member(3, "John"));

            id: 
            Console.WriteLine($"\n-------Welcome to the Smart Library Management System of {myLibrary.name} !----------");

            Console.WriteLine("Are you a Librarian or a Member?");
            Console.WriteLine("1. Librarian");
            Console.WriteLine("2. Member");

            Console.Write("Please select an option: ");
            string userType = Console.ReadLine();

            try
            {

                if (userType == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("\nHey Librarian ! Welcome to the Smart Library Management System!");
                        Console.WriteLine("1. View All Books");
                        Console.WriteLine("2. View All Members");
                        Console.WriteLine("3. Add a Book");
                        Console.WriteLine("4. Add a Member");
                        Console.WriteLine("5. Show Available Books");
                        Console.WriteLine("6. Exit");
                        Console.WriteLine("7. Go Back to Main Menu");
                        Console.Write("Please select an option: ");
                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                myLibrary.GetAllBooks();
                                break;
                            case "2":
                                myLibrary.GetAllMembers();
                                break;
                            case "3":
                                Console.Write("Enter Book ID: ");
                                int bookId = int.Parse(Console.ReadLine());
                                Console.Write("Enter Book Title: ");
                                string title = Console.ReadLine();
                                Console.Write("Enter Book Author: ");
                                string author = Console.ReadLine();
                                Console.Write("Enter Book Genre: ");
                                string genre = Console.ReadLine();
                                myLibrary.AddBook(new Book(bookId, title, author, genre));
                                break;
                            case "4":
                                Console.Write("Enter Member ID: ");
                                int memberId = int.Parse(Console.ReadLine());
                                Console.Write("Enter Member Name: ");
                                string name = Console.ReadLine();
                                myLibrary.AddMember(new Member(memberId, name));
                                break;
                            case "5":
                                myLibrary.ShowAvailableBooks();
                                break;
                            case "6":
                                Console.WriteLine("Exiting the system. Thank you!");
                                return;
                            case "7":
                                goto id;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                }

                else if (userType == "2")
                {

                    while (true)
                    {
                        Console.WriteLine("\nHey Member ! Welcome to the Smart Library Management System!");

                        Console.WriteLine("1. View All Books");
                        //Console.WriteLine("2. View All Members"); 
                        Console.WriteLine("3. Show Available Books");
                        Console.WriteLine("4. Sort Books by Author and Title");
                        Console.WriteLine("5. Borrow a Book");
                        Console.WriteLine("6. Return a Book");
                        Console.WriteLine("7. Exit");
                        Console.WriteLine("8. Go Back to Main Menu");

                        Console.Write("Please select an option: ");

                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                myLibrary.GetAllBooks();
                                break;
                            //case "2":
                            //    myLibrary.GetAllMembers();
                            //    break;
                            case "3":
                                myLibrary.ShowAvailableBooks();
                                break;
                            case "4":
                                myLibrary.SortAndPrintBooksByAuthorAndTitle();
                                break;
                            case "5":
                                Console.Write("Enter Member ID: ");
                                int memberId = int.Parse(Console.ReadLine());
                                Console.Write("Enter Book ID: ");
                                int bookId = int.Parse(Console.ReadLine());
                                myLibrary.BorrowBook(memberId, bookId);
                                break;
                            case "6":
                                Console.Write("Enter Member ID: ");
                                int returnMemberId = int.Parse(Console.ReadLine());
                                Console.Write("Enter Book ID: ");
                                int returnBookId = int.Parse(Console.ReadLine());
                                myLibrary.ReturnBook(returnMemberId, returnBookId);
                                break;
                            case "7":
                                Console.WriteLine("Exiting the system. Thank you!");
                                return;
                            case "8":
                                goto id;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;

                        }
                    }
                }

                else
                {
                    throw new InvalidChoiceException("Invalid Choice");
                }
            }

            catch (InvalidChoiceException e)
            {
                Console.WriteLine(e.Message);
                goto id;
            }
        }
    }
}
