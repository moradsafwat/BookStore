using BookstoreNew.Models;
using BookstoreNew.Repositories;
using BookStoreNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreNew.Repositories
{
    public class AuthorDbRepository : IBookStoreRepo<Author>
    {
        BookStoreDbContext db;

        public AuthorDbRepository(BookStoreDbContext _db)
        {
            db = _db;
        }
        public void Add(Author entity)
        {
            db.Authors.Add(entity);
            Save();
        }

        public void Delete(int id)
        {
            var author = Find(id);

            db.Authors.Remove(author);
            Save();
        }

        public Author Find(int id)
        {
            var author = db.Authors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return db.Authors.ToList();
        }

        public void Update(int id, Author newAuthor)
        {
            db.Update(newAuthor);
            Save();

        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
