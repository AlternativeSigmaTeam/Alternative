using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alternative.Model.Entities;
using Alternative.Model.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Alternative.Web.ViewModels
{
    public class AlternativeViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Guid TeacherId { get; set; }

        public int MaxQuantity { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }

        public IEnumerable<Guid> SelectedUsers { get; set; }

        public IEnumerable<SelectListItem> Teachers { get; set; }

        public IEnumerable<SelectListItem> Courses { get; set; }

        public IEnumerable<Guid> SelectedListCourses { get; set; }

        public Teacher Teacher { get; set; }

        public Guid SelectedTeacher { get; set; }

        public short Priority { get; set; }

    }
}
