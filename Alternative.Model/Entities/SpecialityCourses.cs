using System;
using System.Collections.Generic;
using System.Text;

namespace Alternative.Model.Entities
{
    public class SpecialityCourses 
    {
        public Guid SpecialtyId { get; set; }

        public Guid CourseId { get; set; }

        public Specialty Specialty { get; set; }

        public Course Course { get; set; }
    }
}
