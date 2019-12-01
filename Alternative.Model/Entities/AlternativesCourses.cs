using System;

namespace Alternative.Model.Entities
{
    public class AlternativesCourses
    {
        public Guid AlternativeId { get; set; }

        public Guid CourseId { get; set; }

        public Alternative Alternative { get; set; }

        public Course Course { get; set; }
    }
}
