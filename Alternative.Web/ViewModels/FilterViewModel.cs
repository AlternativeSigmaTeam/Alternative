using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alternative.Model.Enums;
using Alternative.Web.ViewModels.DomainEntitysViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Alternative.Web.ViewModels
{
    public class FilterViewModel
    {
        public IEnumerable<SelectListItem> Specialties { get; set; }

        public Guid SelectedSpecialty { get; set; }

        public IEnumerable<SelectListItem> Courses { get; set; }

        public Guid SelectedCourses { get; set; }

        public Semestr Semestr { get; set; }
    }
}
