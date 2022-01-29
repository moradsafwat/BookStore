using BookstoreNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreNew.Repositories
{
    public interface IBookStoreRepo <TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);


        //IList<TEntity> list();
        //TEntity Find(int id);
        //void Add(TEntity entity);
        //void Update(TEntity entity);
        //void Delete(int id);




    }
}
