using BookstoreNew.Models;
using BookstoreNew.Repositories;
using BookStoreNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreNew.Repositories
{
    public class BookDbRepository : IBookStoreRepo<Book>
    {
        BookStoreDbContext db;
        public BookDbRepository(BookStoreDbContext _db)
        {
            db = _db;
        }
        public Book Find(int id)
        {
            var book = db.Books.SingleOrDefault(b => b.Id == id);

            return book;
        }

        public IList<Book> List()
        {
            return db.Books.ToList();
        }

        public void Add(Book book)
        {
            db.Books.Add(book);
            Save();
        }

        public void Update(int id, Book newBook)
        {
            db.Update(newBook);
            Save();

        }

        public void Delete(int id)
        {
            var book = Find(id);
            db.Books.Remove(book);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}

