using Alternative.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alternative.DAL.EntityConfigurations
{
    public class SpecialtyCoursesConfiguration : IEntityTypeConfiguration<SpecialityCourses>
    {
        public void Configure(EntityTypeBuilder<SpecialityCourses> builder)
        {
            builder.HasOne(s => s.Specialty).WithMany(sc => sc.SpecialityCourseses)
                .HasForeignKey(s => s.SpecialtyId);
            builder.HasOne(s => s.Course).WithMany(sc => sc.SpecialityCourseses)
                .HasForeignKey(s => s.CourseId);
            builder.HasKey(sc => new { sc.SpecialtyId, sc.CourseId});
        }
    }
}
