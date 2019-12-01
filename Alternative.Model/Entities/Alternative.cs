using System;
using System.Collections.Generic;

namespace Alternative.Model.Entities
{
    public class Alternative : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid TeacherId { get; set; }

        public int MaxQuantity { get; set; }

        public bool IsDeleted { get; set; }

        public IEnumerable<UsersAlternatives> UsersAlternatives { get; set; }

        public IEnumerable<AlternativesCourses> AlternativesCourses { get; set; }

        public Teacher Teacher { get; set; }
    }
}