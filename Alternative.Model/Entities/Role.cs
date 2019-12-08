using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Alternative.Model.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string Name { get; set; }

        public IEnumerable<IdentityUserRole<Guid>> UserRoles { get; set; }

    }
}