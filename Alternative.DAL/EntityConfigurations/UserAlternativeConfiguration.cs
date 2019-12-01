using System;
using System.Collections.Generic;
using System.Text;
using Alternative.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alternative.DAL.EntityConfigurations
{
    public class UserAlternativeConfiguration : IEntityTypeConfiguration<UsersAlternatives>
    {
        public void Configure(EntityTypeBuilder<UsersAlternatives> builder)
        {
            builder.HasOne(s => s.User).WithMany(sc => sc.UsersAlternativeses)
                .HasForeignKey(s => s.UserId);
            builder.HasOne(s => s.Alternative).WithMany(sc => sc.UsersAlternatives)
                .HasForeignKey(s => s.AlternativeId);
            builder.HasKey(sc => new { sc.AlternativeId, sc.UserId });
        }
    }
}
