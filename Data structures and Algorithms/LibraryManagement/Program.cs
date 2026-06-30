using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\n===== Library Management System =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Delete Book");
                Console.WriteLine("4. Display Books");
                Console.WriteLine("5. Exit");

                Console.Write("Enter Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Enter Book ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();

                        library.AddBook(new Book(id, title, author));

                        break;

                    case 2:

                        Console.Write("Enter Book ID: ");
                        library.SearchBook(Convert.ToInt32(Console.ReadLine()));

                        break;

                    case 3:

                        Console.Write("Enter Book ID: ");
                        library.DeleteBook(Convert.ToInt32(Console.ReadLine()));

                        break;

                    case 4:

                        library.DisplayBooks();

                        break;

                    case 5:

                        Console.WriteLine("Thank You!");
                        return;

                    default:

                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}