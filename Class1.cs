using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar
{
    internal class Class1
    {
        public void Go()
        {
            var anka = new Book(7);
            List<Book> library = new List<Book>();
            while(true)
            {
                Console.WriteLine("1: Add book, 2: Borrow book, 3: Return book. 4: Show inventory:");

                switch(Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Enter bookname to add book");
                        string bookName = Console.ReadLine();
                        if (IfExists(bookName, library))
                        {
                            IncreasAmount(bookName, library);
                        }
                        else
                            library.Add(AddBook(bookName));
                        break;

                    case "2":
                        Console.WriteLine("Enter bookname that you want to borrow");
                        string title = Console.ReadLine();
                        BorrowBook(title, library);                       
                        break;

                    case "3":
                        Console.WriteLine("Enter bookname that you want to return");
                        string s = Console.ReadLine();
                        ReturnBook(s,library);
                        break;

                    case "4":
                        foreach(Book b in library)
                        {
                            Console.WriteLine($"{b.Title} {b.Amount - b.BorrowedBooks}");
                        }
                        break;

                }
            }
        }
        public void BorrowBook(string bookName, List<Book> list)
        {
            Book book = new Book(1);
            foreach(Book b in list)
            {
                if(b.Title == bookName)
                {
                    book = b;
                }
                try
                {
                    book.BorrowedBooks++;
                }
                catch(Exception)
                {
                    Console.WriteLine("Whe have no examples of this book left to borrow out");
                }
            }
        }
        public void ReturnBook(string title, List<Book> list)
        {
            foreach(Book b in list)
            {
                try
                {
                    if (b.Title == title)
                        b.BorrowedBooks--;
                }catch(Exception)
                {
                    Console.WriteLine("All books are returned");
                }
            }
        }
        public Book AddBook(string bookName)
        {
            Book book = new Book(1);
            book.Title = bookName;
                return book;       
        }
        public void IncreasAmount(string bookName, List<Book> list)
        {
            foreach(Book b in list)
            {
                if (b.Title == bookName)
                    b.Amount++;
            }
        }
        public bool IfExists(string bookName, List<Book> list)
        {
            bool exists = false;
            foreach(Book b in list)
            {
                if (b.Title == bookName)
                    exists = true;
            }
            return exists;
        }
    }
    public class Book
    { 
        private int _amount;
        private string _title;
        private int _borrowedBooks;
        public string Title { get { return _title; } 
            set {
                if (value == null)
                    throw new ArgumentNullException();
                else
                 _title = value;  
            }
        }
        public int BorrowedBooks { get { return _borrowedBooks; }
            set {
                if (value > _amount)
                    throw new ArgumentOutOfRangeException();
                else
                _borrowedBooks = value; 
            }
        }
        public int Amount { get { return _amount; } 
            set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                else
                _amount = value; 
            } 
        }
        public override string ToString()
        {
            return "Title: " + Title + "  Amount: " + Amount;
        }
        public Book(int amount)
        {
            _amount = amount;
        }
    }  
}
