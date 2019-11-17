using System;
using System.Collections.Generic;
using Alternative.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alternative.DAL.EntityConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");

            builder.HasData(GetSeedRoles());
        }

        private List<Role> GetSeedRoles()
        {
            var roles = new List<Role>
            {
                new Role {Id = Guid.NewGuid(), Name = "Admin"},
                new Role {Id = Guid.NewGuid(), Name = "Student"},
                new Role {Id = Guid.NewGuid(), Name = "Teacher"},
            };

            return roles;
        }
    }
}