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
    public class Book
    {
        public int bookId;
        public string title;
        public string author;
        public string genre;
        public bool isAvailable;
        public bool isReturned;
        public DateTime borrowedAt;
        public int borrowedByMemberId;

        public Book(int bookId, string title, string author, string genre)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.isAvailable = true;
            this.isReturned = false;
        }
        
    }
}
