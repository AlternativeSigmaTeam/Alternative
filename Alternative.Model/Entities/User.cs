using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Alternative.Model.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public bool IsDeleted { get; set; }

        public IEnumerable<UserSpecialty> UsersSpecialtys { get; set; }

        public IEnumerable<UsersAlternatives> UsersAlternativeses { get; set; }

        public Guid RoleId { get; set; }

        public Role Role { get; set; }

        public Guid? TeacherId { get; set; }

        public Teacher Teacher { get; set; }
    }
}