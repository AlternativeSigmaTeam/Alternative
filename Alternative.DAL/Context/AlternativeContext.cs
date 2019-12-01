using Alternative.DAL.EntityConfigurations;
using Alternative.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Alternative.DAL.Context
{
    public class AlternativeContext : DbContext
    {
        public AlternativeContext(DbContextOptions<AlternativeContext> options)
            : base(options)
        {
        }

        public DbSet<Model.Entities.Alternative> Alternatives { get; set; }

        public DbSet<Specialty> Specialties { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserSpecialty> UserSpecialties { get; set; }

        public DbSet<UsersAlternatives> UsersAlternativeses { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<AlternativesCourses> AlternativesCourseses { get; set; }

        public DbSet<SpecialityCourses> SpecialityCourseses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new AlternativeCoursesConfiguration());
            modelBuilder.ApplyConfiguration(new SpecialtyConfiguration());
            modelBuilder.ApplyConfiguration(new SpecialtyCoursesConfiguration());
            modelBuilder.ApplyConfiguration(new UserAlternativeConfiguration());
            modelBuilder.ApplyConfiguration(new UserSpecialtyConfiguration());
        }
    }
}