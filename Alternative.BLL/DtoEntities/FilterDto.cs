using System;
using System.Collections.Generic;
using System.Text;
using Alternative.Model.Enums;

namespace Alternative.BLL.DtoEntities
{
    public class FilterDto
    {
        public Guid SelectedSpecialty { get; set; }

        public Guid SelectedCourses { get; set; }

        public Semestr Semestr { get; set; }

        public Guid UserId { get; set; }
    }
}
