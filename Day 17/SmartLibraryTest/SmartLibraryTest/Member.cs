using SmartLibraryTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Smart Library Management System in Console App

//book
//0. BookId
//1. Title
//2. author
//3. borrowed at
//4. isReturned
//5. genre
//6. isAvailable

//method:
//1.sendReturnedMail
//2.sendBorrwedMail

//Members
//0. MemberId
//1. name
//2. borrowedBooks[] (can borrow one or 3 books) 


//library

//1. books[]
//2.members[]
//2.name

//methods:
//1.getAll Books.
//2.Add Books.
//3.Sort books by author and Title
//4. borrow book(memberId, bookId)





namespace SmartLibraryTest
{
    public class Member
    {
        public int MemberId;
        public string Name;
        public List<Book> BorrowedBooks = new List<Book>();

        public Member(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count < 3 && book.isAvailable)
            {
                BorrowedBooks.Add(book);
                book.isAvailable = false;
                book.borrowedAt = DateTime.Now;
                book.isReturned = false;
                book.borrowedByMemberId = MemberId;

                SendBorrowedMail(book);
            }
            else
            {
                Console.WriteLine("Cannot borrow more than 3 books or book is not available.");
            }
        }
        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.isAvailable = true;
                book.isReturned = true;
                book.borrowedAt = DateTime.MinValue; 
                book.borrowedByMemberId = -1; 
                SendReturnedMail(book);
            }
            else
            {
                Console.WriteLine("This book was not borrowed by you.");
            }
        }

        public void SendBorrowedMail(Book book)
        {
            Console.WriteLine($"Email sent to {Name}: You have borrowed '{book.title}' by {book.author}.");
        }
        public void SendReturnedMail(Book book)
        {
            Console.WriteLine($"Email sent to {Name}: You have returned '{book.title}' by {book.author}.");
        }

       
    }
}
