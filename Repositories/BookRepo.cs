using BookstoreNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreNew.Repositories
{
    public class BookRepo : IBookStoreRepo<Book>
    {
        List<Book> books;
        public BookRepo()
        {
            books = new List<Book>()
            {
                new Book
                {
                    Id=1, Title="C# Programming", Description= " C# is widely used for developing desktop applications, web applications and web services"
                },
                new Book
                {
                    Id=2, Title="python Programming", Description= "Python is a programming language that lets you work"
                },
                new Book
                {
                    Id=3, Title="Php Programming", Description= "PHP is a popular general-purpose scripting language that is especially suited to web development."
                },
                new Book
                {
                    Id=4, Title="java Programming", Description= "Java is a programming language and computing platform first released by Sun Microsystems in 1995. It has evolved from humble beginnings to power a large share of today’s digital world, by providing the reliable platform upon which many services and applications are built. New, innovative products and digital services designed for the future continue to rely on Java, as well."
                },
            };
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);

            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Update(int id, Book newBook)
        {
            var book = Find(id);

            book.Title = newBook.Title;
            book.Description = newBook.Description;
            book.Author = newBook.Author;
        }

        public void Delete(int id )
        {
            var book = Find(id);

            books.Remove(book);
        }
    }
}
