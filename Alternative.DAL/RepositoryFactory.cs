using System;
using System.Collections.Generic;
using System.Text;
using Alternative.DAL.Interfaces;
using Alternative.Model.Entities;
using Autofac;

namespace Alternative.DAL
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly ILifetimeScope _lifetimeScope;

        public RepositoryFactory(ILifetimeScope lifetimeScope)
        {
            this._lifetimeScope = lifetimeScope;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return this._lifetimeScope.Resolve<IRepository<T>>();
        }
    }
}
