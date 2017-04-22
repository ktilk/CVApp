using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Interfaces
{
    public interface IEFRepository<T> : IDisposable where T : class
    {
        // get all
        IList<T> All { get; }

        // get all records with filter
        //IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IList<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);

        //get by id
        T GetById(params object[] id);

        //create
        void Add(T entity);

        //update
        void Update(T entity);

        //delete
        void Delete(T entity);
        void Delete(params object[] id);

        void SaveChanges();
    }
}
