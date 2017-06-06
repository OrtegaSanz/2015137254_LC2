using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2015137254_ENT.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Creates
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        //Reads
        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        //Update
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        //Delete
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
