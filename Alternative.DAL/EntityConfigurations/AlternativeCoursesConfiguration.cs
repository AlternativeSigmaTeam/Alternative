using Alternative.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alternative.DAL.EntityConfigurations
{
    public class AlternativeCoursesConfiguration : IEntityTypeConfiguration<AlternativesCourses>
    {
        public void Configure(EntityTypeBuilder<AlternativesCourses> builder)
        {
            builder.HasOne(s => s.Alternative).WithMany(sc => sc.AlternativesCourses)
                .HasForeignKey(s => s.AlternativeId);
            builder.HasOne(s => s.Course).WithMany(sc => sc.AlternativesCourses)
                .HasForeignKey(s => s.CourseId);
            builder.HasKey(sc => new { sc.AlternativeId, sc.CourseId });
        }
    }
}
