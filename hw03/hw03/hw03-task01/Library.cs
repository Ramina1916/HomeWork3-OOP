using System;
using System.Collections.Generic;
using System.Text;

namespace hw03.hw03_task01
{
    public class Library
    {
        // create a list of book
        private List<Book> books = new List<Book>();

        // add book to the library
        public void AddBook(Book book)
        {
            // if user add null object
            if (book == null)
                throw new ArgumentNullException("Book cannot be null, friend!");
            else
            {
                books.Add(book);
                Console.WriteLine($"Book '{book.Title}' added successfully.");
            }

        }

        // borrow a book from the library
        public void BorrowBook(string title)
        {
            if (title == null)
            {
                throw new ArgumentNullException("Title cannot be null, friend!");
            }
            else if (books == null || books.Count == 0)
            {
                Console.WriteLine("No books available in the library :(");
            }
            else
            {

                foreach (Book book in books)
                {
                    if (book.Title == title)
                    {
                        if (book.IsAvailable)
                        {
                            book.IsAvailable = false;
                            Console.WriteLine($"You borrowed '{book.Title}', have a good read :)");
                            return; // stop the method
                        }
                        else
                        {
                            Console.WriteLine("Sorry! this book is not available right now :(");
                            return;
                        }
                    }
                }
                Console.WriteLine("Book not found in the library :(");
            }
        }

        // return a book to the library
        public void ReturnBook(string title)
        {
            if (title == null)
            {
                throw new ArgumentNullException("Title cannot be null, friend!");
            }
            else
            {
                foreach (Book book in books)
                {
                    if (book.Title == title)
                    {
                        if (!book.IsAvailable)
                        {
                            book.IsAvailable = true;
                            Console.WriteLine($"You returned '{book.Title}'.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("This book is already available.");
                            return;
                        }
                    }
                }
            }
        }
    }
}
