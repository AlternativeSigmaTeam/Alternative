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

        public DbSet<Subject> Alternatives { get; set; }

        public DbSet<Faculty> Faculties { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new FacultyConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}