using System;

namespace Alternative.Model.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsDeleted { get; set; }

        public Faculty Faculty { get; set; }

        public Guid RoleId { get; set; }

        public Role Role { get; set; }
    }
}