using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibraryTest
{
    public class Library
    {

        public string name;
        public List<Book> books = new List<Book>();
        public List<Member> members = new List<Member>();

        public Library(string name)
        {
            this.name = name;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.title}' by {book.author} added successfully.");
        }

        public void AddMember(Member member)
        {
            members.Add(member);
            Console.WriteLine($"Member '{member.Name}' added successfully.");
        }

        public void GetAllBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"BookId: {book.bookId}, Title: {book.title}, Author: {book.author}, Genre: {book.genre}, Available: {book.isAvailable}");
            }
        }

        public void GetAllMembers()
        {
            foreach(var member in members)
            {
                Console.WriteLine($"MemberId: {member.MemberId}, Name: {member.Name}, Borrowed Books Count: {member.BorrowedBooks.Count}");
                foreach (var book in member.BorrowedBooks)
                {
                    Console.WriteLine($"  - BookId: {book.bookId}, Title: {book.title}, Author: {book.author}");
                }
            }
        }

        public void SortAndPrintBooksByAuthorAndTitle()
        {
            books = books.OrderBy(b => b.author).ThenBy(b => b.title).ToList();
            
            Console.WriteLine("Books sorted by Author and Title:");
            foreach (var book in books)
            {
                Console.WriteLine($"BookId: {book.bookId}, Title: {book.title}, Author: {book.author}, Genre: {book.genre}, Available: {book.isAvailable}");
            }
        }

        public void ShowAvailableBooks()
        {
            foreach (var book in books)
            {
                if (book.isAvailable)
                {
                    Console.WriteLine($"BookId: {book.bookId}, Title: {book.title}, Author: {book.author}, Genre: {book.genre}");
                }
            }
        }

        public void BorrowBook(int memberId, int bookId)
        {
            var member = members.Find(m => m.MemberId == memberId);
            var book = books.Find(b =>  b.bookId == bookId && b.isAvailable);
          
            if (member != null && book != null)
            {
                member.BorrowBook(book);

            }
            else
            {
                Console.WriteLine("Invalid Member ID or Book ID, or the book is not available.");
            }
        }

        public void ReturnBook(int memberId, int bookId)
        {
            var member = members.Find(m => m.MemberId == memberId);

            var book = books.Find(b => b.bookId == bookId && !b.isAvailable && b.borrowedByMemberId == memberId);
            if (member != null && book != null)
            {
                member.ReturnBook(book);
            }
            else
            {
                Console.WriteLine("Invalid Member ID or Book ID, or the book was not borrowed by this member.");
            }
        }

    }
}