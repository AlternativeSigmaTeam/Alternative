using Alternative.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alternative.DAL.EntityConfigurations
{
    public class UserSpecialtyConfiguration : IEntityTypeConfiguration<UserSpecialty>
    {
        public void Configure(EntityTypeBuilder<UserSpecialty> builder)
        {
            builder.HasOne(s => s.User).WithMany(sc => sc.UsersSpecialtys)
                .HasForeignKey(s => s.UserId);
            builder.HasOne(s => s.Specialty).WithMany(sc => sc.UserSpecialties)
                .HasForeignKey(s => s.SpecialtyId);
            builder.HasKey(sc => new { sc.SpecialtyId, sc.UserId });
        }
    }
}
