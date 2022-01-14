using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AccomidationBooking
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _dbContext;
        internal DbSet<T> _dbSet;

        public Repository(DbContext context)
        {
            _dbContext = context;
            this._dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            // insert into Account
            this._dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            this._dbSet.AddRange(entities);
        }


        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            //include properties will be separated
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            return query.ToList();
        }
        public IEnumerable<T> GetAll()
        {
            return this._dbSet.ToList();
        }
        public T Get(int id)
        {
            return this._dbSet.Find(id);
        }

        public void Remove(int id)
        {
            T entity = this._dbSet.Find(id);
            this._dbSet.Remove(entity);
        }

        public void Remove(T entity)
        {
            this._dbSet.Remove(entity);
        }

        public void RemoveAll(IEnumerable<T> entities)
        {
            this._dbSet.RemoveRange(entities);
        }
    }
}
