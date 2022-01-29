using BookstoreNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreNew.Repositories
{
    public class AuthorRepo : IBookStoreRepo<Author>
    {
        IList<Author> authors;
       

        public AuthorRepo()
        {
            authors = new List<Author>()
            {
                new Author {Id=1, FullName="Morad Safwat"},
                new Author {Id=2, FullName="Mina Safwat"},
                new Author {Id=3, FullName="Ramez hany"},
                new Author {Id=4, FullName="Abanob kamal"}
            }; 
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);

            authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);
            author.FullName = newAuthor.FullName;
            
        }
    }
}
