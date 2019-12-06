using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alternative.Model.Enums;

namespace Alternative.Web.ViewModels.DomainEntitysViewModel
{
    public class AlternativeFilterViewModel
    {
        public IEnumerable<AlternativeViewModel> Alternatives { get; set; }

        public Guid SelectedSpecialty { get; set; }

        public Guid SelectedCourses { get; set; }

        public Semestr Semestr { get; set; }

        public short Priority { get; set; }

        public Guid Id { get; set; }
    }

}
