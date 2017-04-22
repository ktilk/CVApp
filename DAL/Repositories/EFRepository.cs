using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DAL.Repositories
{
    public class EFRepository<T> : IEFRepository<T> where T : class
    {
        protected DbContext DbContext { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public EFRepository(DbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException(nameof(dbContext));
            DbContext = dbContext as DbContext;

            if (DbContext != null)
            {
                DbSet = DbContext.Set<T>();
            }
        }

        public IList<T> All => DbSet.ToList();

        public void Add(T entity)
        {
            EntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(entity);
            }
        }

        public IList<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            return includeProperties.
                Aggregate<Expression<Func<T, object>>, IQueryable<T>>(DbSet,
                    (current, includeProperty) => current.Include(includeProperty)).ToList();
            /*
        	// non linq version
        	foreach (var includeProperty in includeProperties)
        	{
        		query = query.Include(includeProperty);
        	}
        	return query;
        	*/
        }

        public void Delete(T entity)
        {
            EntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                DbSet.Attach(entity);
                DbSet.Remove(entity);
            }
        }

        public void Delete(params object[] id)
        {
            var entity = GetById(id);
            if (entity == null) return;
            Delete(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T GetById(params object[] id)
        {
            return DbSet.Find(id);
        }

        public void Update(T entity)
        {
            EntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}
