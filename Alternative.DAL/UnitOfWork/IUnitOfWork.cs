
using Alternative.DAL.Interfaces;
using Alternative.Model.Entities;

namespace Alternative.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();

        IRepository<T> GetRepository<T>() where T :  BaseEntity;
    }
}
