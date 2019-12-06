using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alternative.Model.Entities;

namespace Alternative.Web.ViewModels.DomainEntitysViewModel
{
    public class SpecialtyViewModel
    {
        public Guid? SpecialtyId { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }
    }
}
