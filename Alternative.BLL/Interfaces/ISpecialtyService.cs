using System;
using System.Collections.Generic;
using System.Text;
using Alternative.Model.Entities;

namespace Alternative.BLL.Interfaces
{
    public interface ISpecialtyService : IService<Specialty>
    {
        IEnumerable<Specialty> GetAllSpecialties();

        Specialty GetSpesialtyById(Guid id);
    }
}
