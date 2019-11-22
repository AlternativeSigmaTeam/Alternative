using System;
using System.Collections.Generic;
using System.Text;
using Alternative.Model.Entities;

namespace Alternative.BLL.Interfaces
{
    public interface IUserService : IService<User>
    {
        bool IsUserExisted(Guid id);

        User GetUserById(Guid id);
    }
}
