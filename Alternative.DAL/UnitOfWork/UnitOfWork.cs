using Alternative.DAL.Context;
using Alternative.DAL.Interfaces;

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

        public IRepository<T> GetRepository<T>() where T : class
        {
            return repositoryFactory.GetRepository<T>();
        }
    }
}
