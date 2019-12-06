using System;
using System.Collections.Generic;
using Alternative.BLL.DtoEntities;
using Alternative.Model.Entities;

namespace Alternative.BLL.Interfaces
{
    public interface IUserService : IService<User>
    {
        bool IsUserExisted(Guid id);

        User GetUserById(Guid id);

        IEnumerable<User> GetAllUsers();

        IEnumerable<User> GetAllFreeUsers();

        bool SaveUserAlternativePriority(UserAlternativeDto alternativeDto);
    }
}
