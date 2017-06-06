using _2015137254_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace _2015137254_PER.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _Context;
        public Repository(_2015137254DbContext context)
        {
            _Context = context;
        }
        void IRepository<TEntity>.Add(TEntity entity)
        {
            _Context.Set<TEntity>().Add(entity);
        }

        void IRepository<TEntity>.AddRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().AddRange(entities);
        }

        void IRepository<TEntity>.Delete(TEntity entity)
        {
            _Context.Set<TEntity>().Remove(entity);
        }

        void IRepository<TEntity>.DeleteRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().RemoveRange(entities);
        }

        IEnumerable<TEntity> IRepository<TEntity>.Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _Context.Set<TEntity>().Where(predicate);
        }

        TEntity IRepository<TEntity>.Get(int Id)
        {
            return _Context.Set<TEntity>().Find(Id);
        }

        IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            return _Context.Set<TEntity>().ToList();
        }

        void IRepository<TEntity>.Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.UpdateRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
