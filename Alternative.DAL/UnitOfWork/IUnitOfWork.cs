
using Alternative.DAL.Interfaces;

namespace Alternative.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();

        IRepository<T> GetRepository<T>() where T :  class;
    }
}
