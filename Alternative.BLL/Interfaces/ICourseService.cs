using System;
using System.Collections.Generic;
using System.Text;
using Alternative.Model.Entities;

namespace Alternative.BLL.Interfaces
{
    public interface ICourseService : IService<Course>
    {
        IEnumerable<Course> GetCoursesByCurrentSpeciality(Guid specialtyId);

        Course GetCourseById(Guid id);
    }
}
