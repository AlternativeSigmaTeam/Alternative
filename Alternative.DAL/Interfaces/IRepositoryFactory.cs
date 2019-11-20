using System;
using System.Collections.Generic;
using System.Text;
using Alternative.Model.Entities;

namespace Alternative.DAL.Interfaces
{
    public interface IRepositoryFactory
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
    }
}
