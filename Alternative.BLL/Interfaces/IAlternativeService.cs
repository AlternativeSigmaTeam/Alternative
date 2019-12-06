using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Alternative.BLL.DtoEntities;

namespace Alternative.BLL.Interfaces
{
    public interface IAlternativeService : IService<Model.Entities.Alternative>
    {
        IEnumerable<Model.Entities.Alternative> GetAllAlternatives();

        Model.Entities.Alternative GetAlternativeByid(Guid id);

        IEnumerable<Model.Entities.Alternative> GetAlternativesByFilter(FilterDto filter);
    }
}
