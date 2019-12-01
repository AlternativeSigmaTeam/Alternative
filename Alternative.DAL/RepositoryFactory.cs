using Alternative.DAL.Interfaces;
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

        public IRepository<T> GetRepository<T>() where T : class
        {
            return this._lifetimeScope.Resolve<IRepository<T>>();
        }
    }
}
