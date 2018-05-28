using BlazorTests.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlazorTests.Server.Controllers
{
    [Produces("application/json")]
    [Route("api/book")]
    public class BookController : Controller
    {
        private static readonly List<Author> authors = new List<Author>{
            new Author{
                AuthorId = 1, Name = "Tom Clancy", Books = new List<Book>
                {
                    new Book{BookId = 1, Title = "Sum of all Fears",YearPublished = 1991, Price = 7.48m},
                    new Book{BookId = 2, Title = "Rainbow Six", YearPublished = 1998, Price = 6.99m},
                    new Book{BookId = 3, Title = "Hunt for Red October", YearPublished = 1984, Price = 4.99m}
                }
            },
            new Author{
                AuthorId = 2, Name = "Stephen King", Books = new List<Book>
                {
                    new Book{BookId = 4, Title = "Carrie", YearPublished = 1974, Price = 5.99m},
                    new Book{BookId = 5, Title = "The Stand", YearPublished = 1978, Price = 4.99m},
                    new Book{BookId = 6, Title = "Black House", YearPublished = 2001, Price = 5.99m},
                    new Book{BookId = 7, Title = "It", YearPublished = 1986, Price = 6.99m}
                }
            },
            new Author{
                AuthorId = 3, Name = "Robert Ludlum", Books = new List<Book>
                {
                    new Book{BookId = 8, Title = "The Bourne Ultimatum", YearPublished = 1990, Price = 5.99m},
                    new Book{BookId = 9, Title = "The Holcroft Covenant", YearPublished = 1978, Price = 4.99m},
                    new Book{BookId = 10, Title = "The Rhineman Exchange", YearPublished = 1974, Price = 4.99m}
                }
            }
        };

        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return authors;
        }
    }
}