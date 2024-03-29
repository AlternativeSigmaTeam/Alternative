﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Alternative.DAL.Context;
using Alternative.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Alternative.DAL.Repository
{
    public class SqlRepository<T> : IRepository<T>
        where T : class
    {
        private readonly AlternativeContext _context;
        private readonly DbSet<T> _set;

        public SqlRepository(AlternativeContext context)
        {
            _context = context;
            _set = context.Set<T>();

        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> filter = null, Func<IEnumerable<T>, IOrderedEnumerable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
        {

            var entities = this._set.AsQueryable();

            if (includes != null)
            {
                entities = includes.Aggregate(entities, (current, include) => current.Include(include));
            }

            if (filter != null)
            {
                entities = entities.Where(filter);
            }

            if (orderBy != null)
            {
                orderBy(entities);
            }

            return entities.ToList();
        }

        public void Delete(T entity)
        {
            this._set.Remove(entity);
        }

        public T GetSingle(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes)
        {
            var entity = _set.Where(filter);
            if (includes != null)
            {
                entity = includes.Aggregate(entity, (current, include) => current.Include(include));
            }

            return entity.FirstOrDefault();
        }

        public void Insert(T entity)
        {
            this._set.Add(entity);
        }

        public void Edit(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _set.Attach(entity);
            }
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
