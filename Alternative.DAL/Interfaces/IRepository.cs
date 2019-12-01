using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Alternative.DAL.Interfaces
{
    public interface IRepository<T>
        where T : class
    {
        void Insert(T entity);

        void Edit(T entity);

        void Delete(T entity);

        T GetSingle(Expression<Func<T, bool>> func = null, params Expression<Func<T, object>>[] includes);

        IEnumerable<T> GetMany(Expression<Func<T, bool>> filter = null, Func<IEnumerable<T>, IOrderedEnumerable<T>> orderBy = null, params Expression<Func<T, object>>[] includes);
    }
}
