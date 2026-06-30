using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    public class Library
    {
        private Dictionary<int, Book> books = new Dictionary<int, Book>();

        // Add Book
        public void AddBook(Book book)
        {
            if (!books.ContainsKey(book.BookId))
            {
                books.Add(book.BookId, book);
                Console.WriteLine("Book Added Successfully.");
            }
            else
            {
                Console.WriteLine("Book ID already exists!");
            }
        }

        // Search Book
        public void SearchBook(int id)
        {
            if (books.ContainsKey(id))
            {
                Book b = books[id];
                Console.WriteLine("\nBook Found");
                Console.WriteLine($"ID: {b.BookId}");
                Console.WriteLine($"Title: {b.Title}");
                Console.WriteLine($"Author: {b.Author}");
            }
            else
            {
                Console.WriteLine("Book Not Found.");
            }
        }

        // Delete Book
        public void DeleteBook(int id)
        {
            if (books.Remove(id))
            {
                Console.WriteLine("Book Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("Book Not Found.");
            }
        }

        // Display All Books
        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Library is Empty.");
                return;
            }

            Console.WriteLine("\n------ Library Books ------");

            foreach (var book in books.Values)
            {
                Console.WriteLine($"ID: {book.BookId}");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine("---------------------------");
            }
        }
    }
}