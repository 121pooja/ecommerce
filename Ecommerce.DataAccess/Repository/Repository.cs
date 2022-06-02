using Ecommerce.DataAccess.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext DbContext;
        internal DbSet<T> DbSet;

        public Repository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<T>();
        }

        public T Add(T entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = DbSet;
            query = query.Where(predicate);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = DbSet;
            return query.ToList();
        }

        public T Delete(T entity)
        {
            DbSet.Remove(entity);
            return entity;
        }
    }
}
