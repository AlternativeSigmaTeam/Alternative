using System;
using System.Collections.Generic;
using System.Text;
using Alternative.Model.Enums;

namespace Alternative.Model.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }

        public Semestr Semestr { get; set; }

        public IEnumerable<AlternativesCourses> AlternativesCourses { get; set;}

        public IEnumerable<SpecialityCourses> SpecialityCourseses { get; set; }
    }
}
