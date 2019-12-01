using System;

namespace Alternative.Model.Entities
{
    public class UserSpecialty
    {
        public Guid UserId { get; set; }

        public Guid SpecialtyId { get; set; }

        public User User { get; set; }

        public Specialty Specialty { get; set; }
    }
}
