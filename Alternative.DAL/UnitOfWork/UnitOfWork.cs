using System;
using System.Collections.Generic;
using System.Text;
using Alternative.DAL.Context;
using Alternative.DAL.Interfaces;
using Alternative.Model.Entities;

namespace Alternative.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AlternativeContext _context;

        private readonly IRepositoryFactory repositoryFactory;

        public UnitOfWork(AlternativeContext context, IRepositoryFactory repositoryFactory)
        {
            _context = context;
            this.repositoryFactory = repositoryFactory;
        }

        public void Commit()
        {
            this._context.SaveChanges();
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return repositoryFactory.GetRepository<T>();
        }
    }
}
