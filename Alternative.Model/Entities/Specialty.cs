using System;
using System.Collections.Generic;
using System.Text;

namespace Alternative.Model.Entities
{
    public class Specialty : BaseEntity
    {
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public IEnumerable<UserSpecialty> UserSpecialties { get; set; }

        public IEnumerable<SpecialityCourses> SpecialityCourseses { get; set; }

    }
}
