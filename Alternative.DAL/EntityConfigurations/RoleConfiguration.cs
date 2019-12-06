using System;
using System.Collections.Generic;
using Alternative.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Alternative.DAL.DalConstants;

namespace Alternative.DAL.EntityConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");

            builder.HasData(new Role {Id = DalConstants.DalConstants.AdminId, Name = "Admin"});
            builder.HasData(new Role {Id = DalConstants.DalConstants.StudentId, Name = "Student"});
            builder.HasData(new Role {Id = DalConstants.DalConstants.TeacherId, Name = "Teacher"});

        }
    }
}