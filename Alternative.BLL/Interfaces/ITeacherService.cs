using System;
using System.Collections.Generic;
using System.Text;
using Alternative.Model.Entities;

namespace Alternative.BLL.Interfaces
{
    public interface ITeacherService : IService<Teacher>
    {
        IEnumerable<Teacher> GetAllTeahers();

        Teacher GetTeacherById(Guid id);

        Teacher GetTeacherByUserId(Guid id);
    }
}
