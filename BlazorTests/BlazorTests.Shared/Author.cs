using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTests.Shared
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public decimal Price { get; set; }
        public Author Author { get; set; }
    }
}
