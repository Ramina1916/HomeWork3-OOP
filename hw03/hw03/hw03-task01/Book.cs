using System;
using System.Collections.Generic;
using System.Text;

namespace hw03.hw03_task01
{
    public class Book
    {
        // class properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

        // constructor
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = true; // by default, a new book is available 
        }
    }
}
